using Microsoft.EntityFrameworkCore;
using Ziare.Data;
using Ziare.Models;
using Ziare.Repositories.GenericRepository;

namespace Ziare.Repositories.ClientiRepository
{
    public class ClientiRepository : GenericRepository<Client>, IClientiRepository
    {
        public ClientiRepository(ZiarContext context) : base(context) { }

        public async Task<Client> FindByEmailAsync(string email)
        {
            return await _table.FirstOrDefaultAsync(x => x.Email == email);
        }

        public Client FindById(Guid id)
        {
            return  _table.FirstOrDefault(x => x.Id == id);
        }
    }
}
