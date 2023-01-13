using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ziare.Data;

namespace Ziare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BibliotecaController : ControllerBase
    {
        private ZiarContext _ZiarContext;

        public BibliotecaController(ZiarContext ZiarContext)
        {
            _ZiarContext = ZiarContext;
        }
    }
}
