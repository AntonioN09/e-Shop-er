using System.ComponentModel.DataAnnotations;

namespace EShop.Models.DTOs
{
    public class UserAuthRequestDto
    {
        [Required]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
