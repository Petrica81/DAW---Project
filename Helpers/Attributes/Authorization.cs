using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Ziare.Models;
using Ziare.Models.Enums;

namespace Ziare.Helpers.Attributes
{
    public class Authorization : Attribute, IAuthorizationFilter
    {
        private readonly ICollection<Roles> _roles;

        public Authorization(params Roles[] roles)
        {
            _roles = roles;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var unauthorizedStatusObject = new JsonResult(new {Messsage = "Unauthorized" }){StatusCode = StatusCodes.Status401Unauthorized};
            if (_roles == null)
            {
                context.Result = unauthorizedStatusObject;
            }

            var client = (Client)context.HttpContext.Items["Client"];
            if (client == null || !_roles.Contains(client.Role))
            {
                context.Result = unauthorizedStatusObject; 
            }
        }
    }
}
