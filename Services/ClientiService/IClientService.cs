using Ziare.Models.DTOs;
using Ziare.Models;
using Ziare.Models.DTOs.ClientDTOs;

namespace Ziare.Services.ClientiService
{
    public interface IClientService
    {
        Task<ClientResponseDTO> AuthenticateAsync(ClientAuthRequestDTO _client);
        Task<List<Client>> GetAll();
        Client GetById(Guid id);
        Task Create(Client newClient);
        Task<Client> CreateAsync(ClientRequestDTO client);
        //Task<bool> Update(Guid id, ClientResultsDTO client);
        Task Delete(Guid id);
    }
}
