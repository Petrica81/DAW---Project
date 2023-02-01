using Ziare.Data;
using Ziare.Models;
using Ziare.Repositories.GenericRepository;

namespace Ziare.Repositories.BiblioteciRepository
{
    public class BiblioteciRepository : GenericRepository<Biblioteca>, IBiblioteciRepository
    {
        public BiblioteciRepository(ZiarContext context) : base(context) { }
    }
}
