using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Models
{
    public class Cart
    { 
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? UserId { get; set; }
    public int? ProductId { get; set; }
    public int Count { get; set; }

    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<Order>? Orders { get; set; }
    }
}
