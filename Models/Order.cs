using System.ComponentModel.DataAnnotations;

namespace EShop.Models
{
    //This entity describes the interest of a user for a product, not exactly a purchase
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? UserId { get; set; }
        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }

        public virtual Cart Cart { get; set; }
    }
}
