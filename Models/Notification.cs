using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Models
{
    public class Notification
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        //Used to express what kind of notification: system/discount/informative
        public String? Title { get; set; }

        public String? Description { get; set; }

        public Boolean IsActive { get; set; }

        public DateTime? CreatedDate { get; set;}

        public virtual User? User { get; set; }
    }
}
