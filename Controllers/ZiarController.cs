using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ziare.Models;
using Ziare.Models.DTOs.ArticolDTOs;
using Ziare.Models.DTOs.ZiarDTOs;
using Ziare.Services.ArticoleService;
using Ziare.Services.ZiareService;

namespace Ziare.Controllers
{
    [Route("api/ziare")]
    [ApiController]
    public class ZiarController : ControllerBase
    {
        private IZiarService _ziarService;

        public ZiarController(IZiarService ziarService)
        {
            _ziarService = ziarService;
        }

        //endpoint pentru a lista toate ziarele
        [HttpGet("all")]
        public Task<List<Ziar>> GetZiare()
        {
            return _ziarService.GetAll();
        }

        //endpoint pentru a adauga un ziar(fara articole)
        [HttpPost("add")]
        public async Task<ActionResult<ZiarResultsDTO>> AddZiar(ZiarRequestDTO ziar)
        {
            var ziar2 = new Ziar
            {
                Titlu = ziar.Titlu,
                Editura = ziar.Editura,
                Domeniu = ziar.Domeniu,
                Pret = ziar.Pret
            };
            await _ziarService.Create(ziar2);

            return Ok(new ZiarResultsDTO(ziar2));
        }

        [HttpPut("edit/{id}")]
        public async Task<ActionResult> UpdateZiar(Guid id, [FromBody] ZiarResultsDTO ziar)
        {
            var verif = await _ziarService.Update(id, ziar);
            if (!verif)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> DeleteZiar(Guid id)
        {
            await _ziarService.Delete(id);
            return Ok();    
        }

        
    }
}
