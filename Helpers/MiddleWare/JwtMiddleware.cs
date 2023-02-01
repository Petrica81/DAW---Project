using Ziare.Helpers.JwtUtils;
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

        public async Task Invoke(HttpContext httpContext, IEditorService editorService, IJwtUtils jwtUtils)
        {
            var token = httpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split("").Last();
            var userId = jwtUtils.ValidateJwtToken(token);
            if (userId != Guid.Empty)
            {
                httpContext.Items["Editor"] = editorService.GetById(userId);
            }
            await _nextRequestDelegate(httpContext);
        }
    }
}
