using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Models
{
    public class Cart
    { 
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? UserId { get; set; }

    //The number of orders in the cart
    public int? Count { get; set; }

    public virtual ApplicationUser? User { get; set; }
    public virtual ICollection<Order>? Orders { get; set; }
    }
}
