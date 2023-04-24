using Microsoft.AspNetCore.Identity;

namespace EShop.Models
{
    public class ApplicationRole : IdentityRole
    {
        public string? RoleName { get; set; }
        public virtual ICollection<ApplicationUserRole>? UserRoles { get; set; }
    }
}

