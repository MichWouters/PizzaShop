﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaShop.Data.Entities
{
    public class Order : Entity
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public virtual Customer Customer { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public bool IsDelivery { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}