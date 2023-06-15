using EShop.Models;

namespace EShop.Models.DTOs
{
    public class UserAuthResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Token { get; set; }

        public UserAuthResponseDto(User user, string token)
        {
            Id = user.Id;
            Name = user.FirstName;
            Token = token;
        }
    }
}
