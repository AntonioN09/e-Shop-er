using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EShop.Models
{
    // This entity is useful for product sorting
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public int? Count { get; set; }

        [Required(ErrorMessage = "Numele categoriei este obligatoriu")]
        public string? CategoryName { get; set; }
        public virtual ICollection<Product>? Products { get; set; }

    }
}
