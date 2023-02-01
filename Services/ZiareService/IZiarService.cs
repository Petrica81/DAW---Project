using Microsoft.AspNetCore.Mvc;
using Ziare.Models;
using Ziare.Models.DTOs.ZiarDTOs;

namespace Ziare.Services.ZiareService
{
    public interface IZiarService
    {
        Task<List<Ziar>> GetAll();

        IAsyncEnumerable<Ziar> GetAllEnumerable();
        Task<List<ZiarResultsDTO>> GetAllDTO();
        Task<Ziar> GetById(Guid id);
        Task<bool> TestareZiarId(Guid id);
        Task Create(Ziar newziar);
        Task<bool> Update(Guid id, ZiarResultsDTO ziar);
        Task Delete(Guid id);
    }
}
