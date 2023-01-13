using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ziare.Data;
using Ziare.Models;
using Ziare.Models.DTOs;

namespace Ziare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZiarController : ControllerBase
    {
        private ZiarContext _ZiarContext;

        public ZiarController(ZiarContext ZiarContext)
        {
            _ZiarContext = ZiarContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetZiare()
        {
            return Ok(await _ZiarContext.Ziare.ToListAsync());
        }
        [HttpGet("ZiarById/{id}")]
        public async Task<IActionResult> GetZiarById([FromRoute] Guid id)
        {
            var ZiarById = _ZiarContext.Ziare.FirstOrDefault(x => x.Id == id);

            return Ok(ZiarById);
        }

        [HttpPost("CreateZiar")]
        public async Task<IActionResult> Create(ZiarDTO ziarDTO)
        {
            var NewZiar = new Ziar();
            NewZiar.Titlu = ziarDTO.Titlu;
            NewZiar.Editura = ziarDTO.Editura;
            NewZiar.Pret =  ziarDTO.Pret;

            await _ZiarContext.AddAsync(NewZiar);
            await _ZiarContext.SaveChangesAsync();

            return Ok(NewZiar);
        }

        
    }
}
