using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EShop.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Numele este obligatoriu")]
        [StringLength(100, ErrorMessage = "Numele nu poate avea mai mult de 100 de caractere")]
        [MinLength(5, ErrorMessage = "Numele trebuie sa aiba mai mult de 5 de caractere")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Descrierea produsului este obligatorie")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Pretul produsului este obligatoriu")]
        public decimal? Price { get; set; } = 0;

        [Url]
        public string? Photo { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; }

        public virtual ICollection<Order>? Orders { get; set; }

        public virtual ApplicationUser? User { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem>? Categ { get; set; }

    }

}
