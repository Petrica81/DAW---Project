using Ziare.Models;
using Ziare.Models.DTOs.EditorDTOs;

namespace Ziare.Services.EditoriService
{
    public interface IEditorService
    {
        Task<bool> Update(Guid id, EditorResponseDTO newEditor);
        Task<List<Editor>> GetAll();
        Task Create(Editor newEditor);
        Task Delete(Guid id);

        List<NumarEditoriDTO> CountEditori();
    }
}
