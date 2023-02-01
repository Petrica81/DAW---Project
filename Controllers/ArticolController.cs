using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ziare.Data;
using Ziare.Models.DTOs.ZiarDTOs;
using Ziare.Models;
using Ziare.Services.ArticoleService;
using Ziare.Models.DTOs.ArticolDTOs;
using Ziare.Services.ZiareService;

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
        [HttpGet("all")]
        public Task<List<Articol>> GetArticole()
        {
            return _articolService.GetAll();
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> DeleteArticol(Guid id)
        {
            await _articolService.Delete(id);
            return Ok();
        }
    }
}
