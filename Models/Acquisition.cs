using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Models
{
    public class Acquisition
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public Product Product { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
