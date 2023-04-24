﻿using System.ComponentModel.DataAnnotations;

namespace EShop.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string? UserId { get; set; }
        public int? ProductId { get; set; }

        public virtual Product? Product { get; set; }

        public virtual ApplicationUser? User { get; set; }
    }
}