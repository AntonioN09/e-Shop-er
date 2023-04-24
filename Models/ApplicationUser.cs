using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Product>? Products { get; set; }

        public virtual ICollection<ApplicationUser>? Users { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public virtual ICollection<Cart>? Carts { get; set; }

        public virtual ICollection<Order>? Orders { get; set; }

        public virtual ICollection<ApplicationUserRole>? UserRoles { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem>? AllRoles { get; set; }

    }
}
