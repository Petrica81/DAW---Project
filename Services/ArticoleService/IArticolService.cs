using Ziare.Models;
using Ziare.Models.DTOs.ArticolDTOs;

namespace Ziare.Services.ArticoleService
{
    public interface IArticolService
    {
        Task<bool> Update(Guid id, ArticolResponseDTO newArticol);
        Task<List<Articol>> GetAll();
        Task Create(Articol newarticol);
        Task Delete(Guid id);

    }
}
