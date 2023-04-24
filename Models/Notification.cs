using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Models
{
    public class Notification
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public String Title { get; set; }
        public String Description { get; set; }

        public DateTime CreatedDate { get; set;}

        public virtual ApplicationUser User { get; set; }
    }
}
