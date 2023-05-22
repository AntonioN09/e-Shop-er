﻿using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Models
{
    public class History
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //The acquisition list of a certain user
        public ICollection<Acquisition>? Acquisitions { get; set; }

        //Foreign key to User - History relationship
        public int? UserId { get; set; }

        public virtual User? User { get; set; }
    }
}
