using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Models
{
    public class Acquisition
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public Product? Product { get; set; }

        //Initialized with current date time
        public DateTime? CreatedDate { get; set; }

        public virtual User? User { get; set; }
    }
}
