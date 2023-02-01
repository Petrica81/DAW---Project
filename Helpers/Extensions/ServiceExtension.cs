using Microsoft.Extensions.DependencyInjection;
using Ziare.Helpers.Seeders;
using Ziare.Repositories;
using Ziare.Repositories.ArticoleRepository;
using Ziare.Repositories.BiblioteciRepository;
using Ziare.Repositories.ClientiRepository;
using Ziare.Repositories.EditoriRepository;
using Ziare.Repositories.ZiareRepository;
using Ziare.Services.ArticoleService;
using Ziare.Services.BiblioteciService;
using Ziare.Services.ClientiService;
using Ziare.Services.EditoriService;
using Ziare.Services.ZiareService;
using Ziare.Services.ZiarService;

namespace Ziare.Helpers.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IZiareRepository, ZiareRepository>();
            services.AddTransient<IClientiRepository, ClientiRepository>();
            services.AddTransient<IBiblioteciRepository, BiblioteciRepository>();
            services.AddTransient<IArticoleRepository, ArticoleRepository>();
            services.AddTransient<IEditoriRepository, EditoriRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;

        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IZiarService, ZiarService>();
            services.AddTransient<IBibliotecaService, BibliotecaService>();
            services.AddTransient<IArticolService, ArticolService>();
            services.AddTransient<IEditorService, EditorService>();
            services.AddTransient<IClientService, ClientService>();

            return services;
        }

        public static IServiceCollection AddSeeders(this IServiceCollection services)
        {
            services.AddTransient<ZiareSeeder>();

            return services;
        }
    }
}
