using Ziare.Data;
using Ziare.Models;
using Ziare.Repositories.GenericRepository;

namespace Ziare.Repositories.ClientiRepository
{
    public class ClientiRepository : GenericRepository<Client>, IClientiRepository
    {
        public ClientiRepository(ZiarContext context) : base(context) { }

        public Client FindByEmail(string email)
        {
            return _table.FirstOrDefault(x => x.Email == email);
        }
    }
}
