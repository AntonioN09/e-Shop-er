using EShop.Controllers;
using EShop.Controllers.Jwt;
using EShop.Data;

namespace EShop.Helpers.Middleware
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;

        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, ApplicationDbContext db, IJwtUtils jwtUtils)
        {
            var token = httpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            var userId = jwtUtils.ValidateJwtToken(token);

            if (userId != Guid.Empty)
            {

                httpContext.Items["User"] = db.Users.Find(userId);

            }

            await _next(httpContext);
        }
    }
}
