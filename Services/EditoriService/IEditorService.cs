using Ziare.Models;
using Ziare.Models.DTOs.EditorDTOs;

namespace Ziare.Services.EditoriService
{
    public interface IEditorService
    { 
        EditorRequestDTO GetById(Guid id);
        Task<List<Editor>> GetAll();
        Task Create(Editor newEditor);
        Task Delete(Guid id);
    }
}
