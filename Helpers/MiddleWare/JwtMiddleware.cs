using Ziare.Helpers.JwtUtils;
using Ziare.Services.ClientiService;
using Ziare.Services.EditoriService;

namespace Ziare.Helpers.MiddleWare
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _nextRequestDelegate;

        public JwtMiddleware(RequestDelegate requestDelegate)
        {
            _nextRequestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext httpContext, IClientService clientService, IJwtUtils jwtUtils)
        {
            var token = httpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split("").Last();
            var clientId = jwtUtils.ValidateJwtToken(token);
            if (clientId != Guid.Empty)
            {
                httpContext.Items["Client"] =  clientService.GetById(clientId);
            }
            await _nextRequestDelegate(httpContext);
        }
    }
}
