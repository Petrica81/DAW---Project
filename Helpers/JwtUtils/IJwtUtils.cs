using Ziare.Models;

namespace Ziare.Helpers.JwtUtils
{
    public interface IJwtUtils
    {
        string GenerateJwtToken(Client client);
         Guid ValidateJwtToken(string token);
    }
}
