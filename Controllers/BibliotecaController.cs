using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ziare.Data;
using Ziare.Services.BiblioteciService;

namespace Ziare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BibliotecaController : ControllerBase
    {
        public IBibliotecaService _bibliotecaService;

        public BibliotecaController(IBibliotecaService bibliotecaService)
        {
            _bibliotecaService = bibliotecaService;
        }
    }
}
