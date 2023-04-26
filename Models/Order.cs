using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Models
{
    //This entity describes the interest of a user for a product, not exactly a purchase
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UserId { get; set; }
        public int? ProductId { get; set; }

        public virtual Product? Product { get; set; }

        public virtual Cart? Cart { get; set; }
    }
}
