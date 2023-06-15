using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Models
{
    public class History
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        //The acquisition list of a certain user
        public ICollection<Acquisition>? Acquisitions { get; set; }

        //Foreign key to User - History relationship
        public Guid? UserId { get; set; }

        public virtual User? User { get; set; }
    }
}
