using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Models
{
    public class Notification
    {
        // Automatically generated when new insertion into database occurs
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        
        // Used to express what kind of notification: system/discount/informative
        public String? Title { get; set; }

        // The content of the notification
        public String? Description { get; set; }

        // The status of the notification, used for frontend design
        public Boolean IsActive { get; set; }

        // User should know the time of the notification
        public DateTime? CreatedDate { get; set;}

        // A reference to the user who receives it 
        public virtual User? User { get; set; }
    }
}
