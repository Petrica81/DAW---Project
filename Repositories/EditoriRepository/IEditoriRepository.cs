using Ziare.Models;
using Ziare.Models.DTOs.EditorDTOs;
using Ziare.Repositories.GenericRepository;

namespace Ziare.Repositories.EditoriRepository
{
    public interface IEditoriRepository : IGenericRepository<Editor>
    {
        public Editor FindByEmail(string email);
        List<NumarEditoriDTO> CountEditori();
    }
}
