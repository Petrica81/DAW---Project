using Ziare.Data;
using Ziare.Models;
using Ziare.Repositories.GenericRepository;

namespace Ziare.Repositories.EditoriRepository
{
    public class EditoriRepository : GenericRepository<Editor>, IEditoriRepository
    {
        public EditoriRepository(ZiarContext context) : base(context) { }

        public Editor FindByEmail(string email)
        {
            return _table.FirstOrDefault(x => x.Email == email);
        }
    }
}
