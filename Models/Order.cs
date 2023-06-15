using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Models
{
    //This entity describes the interest of a user for a product, not exactly a purchase
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? UserId { get; set; }
        public Guid? ProductId { get; set; }

        public virtual Product? Product { get; set; }

        public virtual Cart? Cart { get; set; }
    }
}
