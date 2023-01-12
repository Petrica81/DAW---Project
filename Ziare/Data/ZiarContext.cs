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

    }
}
