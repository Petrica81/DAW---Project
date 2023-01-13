using Ziare.Models;
using Microsoft.EntityFrameworkCore;
using Ziare.Models.Base;

namespace Ziare.Data
{
    public class ZiarContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Ziar> Ziare { get; set; }
        public DbSet<Editor> Editori { get; set; }
        public DbSet<Articol> Articole { get; set; }
        public DbSet<Biblioteca> Biblioteci { get; set; }
        public ZiarContext(DbContextOptions<ZiarContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one to many
            modelBuilder.Entity<Ziar>()
                .HasMany(z => z.Articole)
                .WithOne(a => a.Ziar);

            //many to many
            modelBuilder.Entity<ZiarEditorRelation>()
                .HasKey(zer => new { zer.ZiarId, zer.EditorId });
            modelBuilder.Entity<ZiarEditorRelation>()
                .HasOne<Ziar>(zer => zer.Ziar)
                .WithMany(z => z.ZiarEditorRelations)
                .HasForeignKey(zer => zer.ZiarId);
            modelBuilder.Entity<ZiarEditorRelation>()
                .HasOne<Editor>(zer => zer.Editor)
                .WithMany(e => e.ZiarEditorRelations)
                .HasForeignKey(zer => zer.EditorId);

            //many to many
            modelBuilder.Entity<ZiarBibliotecaRelation>()
                .HasKey(zbr => new { zbr.ZiarId, zbr.BibliotecaId });
            modelBuilder.Entity<ZiarBibliotecaRelation>()
                .HasOne<Ziar>(zbr => zbr.Ziar)
                .WithMany(z => z.ZiarBibliotecaRelations)
                .HasForeignKey(zbr => zbr.ZiarId);
            modelBuilder.Entity<ZiarBibliotecaRelation>()
                .HasOne<Biblioteca>(zbr => zbr.Biblioteca)
                .WithMany(b => b.ZiarBibliotecaRelations)
                .HasForeignKey(zbr => zbr.BibliotecaId);

            //one to one
            modelBuilder.Entity<Biblioteca>()
                .HasOne(b => b.Client)
                .WithOne(c => c.Biblioteca)
                .HasForeignKey<Client>(c => c.BibliotecaId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
