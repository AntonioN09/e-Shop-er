using EShop.Models;

namespace EShop.Controllers.Jwt
{
    public interface IJwtUtils
    {
        public string GenerateJwtToken(User user);
        public Guid ValidateJwtToken(string token);
    }
}
