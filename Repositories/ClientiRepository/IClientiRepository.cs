using Ziare.Models;
using Ziare.Repositories.GenericRepository;

namespace Ziare.Repositories.ClientiRepository
{
    public interface IClientiRepository : IGenericRepository<Client>
    {
        Client FindByEmail(string email);
    }
}
