using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Models
{
    public class History
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public ICollection<Product>? Products { get; set; }

        public string? UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
