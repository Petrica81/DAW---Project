using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ziare.Data;
using Ziare.Helpers.JwtUtils;
using Ziare.Models.DTOs.ClientDTOs;
using Ziare.Services.ClientiService;

namespace Ziare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private IClientService _clientService;
        private IMapper _mapper;
        public IJwtUtils _jwtUtils;

        public ClientController( IClientService clientService, IMapper mapper, IJwtUtils jwtUtils)
        {
            _clientService = clientService;
            _mapper = mapper;
            _jwtUtils = jwtUtils;
        }


        //register pentru clienti
        [HttpPost("register")]
        public async Task<IActionResult> Register(ClientRequestDTO client)
        {
            var _client = await _clientService.CreateAsync(client);

            if (_client == null)
                return BadRequest();

            var _client2 = _mapper.Map<ClientResponseDTO>(_client);
            return Ok(_client2);
        }


        //log in pentru clienti
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate(ClientAuthRequestDTO client)
        {
            var res = await _clientService.AuthenticateAsync(client);
            if (res == null)
            {
                return BadRequest("Username or password is invalid!");
            }
            return Ok(res);
        }

    }
}
