using Ziare.Models;
using Ziare.Repositories.GenericRepository;

namespace Ziare.Repositories.ZiareRepository
{
    public interface IZiareRepository : IGenericRepository<Ziar>
    {
        Task<Ziar> GetById(Guid id);
        //List<Ziar> GetByTitlu(string titlu);
        //List<Ziar> GetByDomeniu(string domeniu);
        //List<Ziar> GetByEditura(string editura);
        //List<Ziar> GetByPret(int pretminim, int pretmaxim);
    }
}
