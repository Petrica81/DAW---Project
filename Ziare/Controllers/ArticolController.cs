﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ziare.Data;

namespace Ziare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticolController : ControllerBase
    {
        private ZiarContext _ZiarContext;
        public ArticolController(ZiarContext ZiarContext)
        {
            _ZiarContext = ZiarContext;
        }
    }
}