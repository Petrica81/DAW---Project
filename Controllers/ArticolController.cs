using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ziare.Data;
using Ziare.Models.DTOs.ZiarDTOs;
using Ziare.Models;
using Ziare.Services.ArticoleService;
using Ziare.Models.DTOs.ArticolDTOs;
using Ziare.Services.ZiareService;
using Microsoft.AspNetCore.Authorization;
using Ziare.Models.Enums;

namespace Ziare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticolController : ControllerBase
    {
        private IArticolService _articolService;
        public ArticolController(IArticolService articolService)
        {
            _articolService = articolService;
        }
        [HttpGet("all"), Authorize(Roles = "Client, Admin")]
        public Task<List<Articol>> GetArticole()
        {
            return _articolService.GetAll();
        }
        [HttpPost("add"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ArticolResponseDTO>> AddArticol(ArticolRequestDTO articol)
        {
            var articol2 = new Articol
            {
                Titlu = articol.Titlu
            };

            await _articolService.Create(articol2);
            return Ok(new ArticolResponseDTO(articol2));
        }

        [HttpPut("edit/{id}"), Authorize(Roles = "Admin")]
        public async Task<ActionResult> UpdateArticol(Guid id, [FromBody] ArticolResponseDTO articol)
        {
            var verif = await _articolService.Update(id, articol);
            if (verif != null)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete("delete/{id}"), Authorize(Roles = "Admin")]
        public async Task<ActionResult> DeleteArticol(Guid id)
        {
            await _articolService.Delete(id);
            return Ok();
        }
    }
}
