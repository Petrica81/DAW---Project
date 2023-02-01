using Ziare.Models;

namespace Ziare.Services.ArticoleService
{
    public interface IArticolService
    {
        Task<List<Articol>> GetAll();
        Task Create(Articol newarticol);
        Task Delete(Guid id);

    }
}
