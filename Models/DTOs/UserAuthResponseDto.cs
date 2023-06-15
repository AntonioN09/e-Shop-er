using EShop.Models;

namespace EShop.Models.DTOs
{
    public class UserAuthResponseDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Token { get; set; }

        public UserAuthResponseDto(User user, string token)
        {
            Id = user.Id;
            user.FirstName = user.FirstName;
            user.LastName = user.LastName;
            Token = token;
        }
    }
}
