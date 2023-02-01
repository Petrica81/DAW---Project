using Ziare.Data;
using Ziare.Models;
using Ziare.Repositories.GenericRepository;

namespace Ziare.Repositories.ArticoleRepository
{
    public class ArticoleRepository : GenericRepository<Articol>, IArticoleRepository
    {
        public ArticoleRepository (ZiarContext context) : base (context) { }
    }
}
