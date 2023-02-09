using Ziare.Data;
using Ziare.Models;
using Ziare.Models.DTOs.EditorDTOs;
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


        public List<NumarEditoriDTO> CountEditori()
        {
            return _table.GroupBy(e => e.Editura)
                         .Select(x => new NumarEditoriDTO { Editura = x.Key, Count = x.Count() })
                         .ToList();
        }

    }

}
