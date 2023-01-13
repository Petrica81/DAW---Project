using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ziare.Data;

namespace Ziare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditorController : ControllerBase
    {
        private ZiarContext _ZiarContext;
        public EditorController(ZiarContext ZiarContext)
        {
            _ZiarContext = ZiarContext;
        }
    }
}
