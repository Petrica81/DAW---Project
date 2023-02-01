using Ziare.Helpers.Extensions;
using Ziare.Helpers;
using Ziare.Helpers.MiddleWare;
using Ziare.Helpers.JwtUtils;
using Microsoft.EntityFrameworkCore;
using Ziare.Data;
using Ziare.Helpers.Seeders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ZiarContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
//adaugat manual
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddEndpointsApiExplorer();
//repositories
builder.Services.AddRepositories();
//services
builder.Services.AddServices();
builder.Services.AddTransient<IJwtUtils, JwtUtils>();
//seeders
builder.Services.AddSeeders();
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.MapControllers();

app.UseMiddleware<JwtMiddleware>();

app.Run();

void SeedData(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();
    using (var scope = scopedFactory.CreateScope())
    {
        var service = scope.ServiceProvider.GetService<ZiareSeeder>();
        service.SeedInitialZiare();
    }
}