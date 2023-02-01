using Ziare.Models.DTOs;
using Ziare.Models;
using Ziare.Models.DTOs.ClientDTOs;

namespace Ziare.Services.ClientiService
{
    public interface IClientService
    {
        ClientResponseDTO Authenticate(ClientRequestDTO _client);
        Task<List<Client>> GetAll();
        Task Create(Client newClient);
        //Task<bool> Update(Guid id, ClientResultsDTO client);
        Task Delete(Guid id);
    }
}
