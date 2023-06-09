﻿using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.Models
{
    public class Cart
    { 
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public Guid? UserId { get; set; }

    //The number of orders in the cart
    public int? Count { get; set; }

    public virtual User? User { get; set; }
    public virtual ICollection<Order>? Orders { get; set; }
    }
}
