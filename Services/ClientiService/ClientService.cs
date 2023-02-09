using AutoMapper;
using Ziare.Helpers.JwtUtils;
using Ziare.Models;
using Ziare.Models.DTOs.ClientDTOs;
using Ziare.Models.DTOs.EditorDTOs;
using Ziare.Repositories;
using BCryptNet = BCrypt.Net.BCrypt;

namespace Ziare.Services.ClientiService
{
    public class ClientService : IClientService
    {
        public IUnitOfWork _unitOfWork;
        public IMapper _mapper;
        public IJwtUtils _jwtUtils;

        public ClientService(IUnitOfWork unitOfWork, IMapper mapper, IJwtUtils jwtUtils)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _jwtUtils = jwtUtils;
        }

        public async Task<List<Client>> GetAll()
        {
            var clienti = await _unitOfWork.ClientiRepository.GetAll();
            return _mapper.Map<List<Client>>(clienti);
        }

        public Client GetById(Guid id)
        {
            var client =  _unitOfWork.ClientiRepository.FindById(id);
            return _mapper.Map<Client>(client);
        }
        public async Task<ClientResponseDTO> AuthenticateAsync(ClientAuthRequestDTO _client)
        {
            var client = await _unitOfWork.ClientiRepository.FindByEmailAsync(_client.Email);
            if (client == null || !BCryptNet.Verify(_client.Password, client.PasswordHash))
            {
                return null;
            }

            var jwtToken = _jwtUtils.GenerateJwtToken(client);
            return new ClientResponseDTO(client, jwtToken);
        }
        public async Task Create(Client newClient)
        {
            await _unitOfWork.ClientiRepository.CreateAsync(newClient);
            await _unitOfWork.ClientiRepository.SaveAsync();
        }
        public async Task<Client> CreateAsync(ClientRequestDTO client)
        {
            var newClient= new Client(client);
            await _unitOfWork.ClientiRepository.CreateAsync(newClient);
            try
            {
                await _unitOfWork.SaveAsync();
            }
            catch (Exception)
            {
                return null;
            }
            return newClient;
        }

        public async Task Delete(Guid id)
        {
            var client = await _unitOfWork.ClientiRepository.FindByIdAsync(id);

            _unitOfWork.ClientiRepository.Delete(client);
            await _unitOfWork.ClientiRepository.SaveAsync();
        }
    }
}
