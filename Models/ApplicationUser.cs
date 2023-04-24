using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Models
{
    public class ApplicationUser : IdentityUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public virtual ICollection<ApplicationUser>? Users { get; set; }

        public virtual Cart? Cart { get; set; }

        public virtual History? History { get; set; }

        public virtual ICollection<Acquisition>? Acquisitions { get; set; }

        public virtual ICollection<Notification>? Notifications { get; set; }

        public virtual ICollection<ApplicationUserRole>? UserRoles { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem>? AllRoles { get; set; }

    }
}
