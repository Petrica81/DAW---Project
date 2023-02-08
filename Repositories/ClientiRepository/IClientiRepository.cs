using Ziare.Models;
using Ziare.Repositories.GenericRepository;

namespace Ziare.Repositories.ClientiRepository
{
    public interface IClientiRepository : IGenericRepository<Client>
    {
        Task<Client> FindByEmailAsync(string email);
    }
}
