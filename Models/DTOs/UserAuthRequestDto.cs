using System.ComponentModel.DataAnnotations;

namespace EShop.Models.DTOs
{
    public class UserAuthRequestDto
    {
        [Required]
        public string Password { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
