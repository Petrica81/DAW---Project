using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ziare.Data;

namespace Ziare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private ZiarContext _ZiarContext;

        public ClientController(ZiarContext ZiarContext)
        {
            _ZiarContext = ZiarContext;
        }
    }
}
