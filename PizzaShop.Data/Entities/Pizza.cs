﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaShop.Data.Entities
{
    public class Pizza : Entity
    {
        [Key]
        public int PizzaId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        [Required]
        [Range(0, 99.99)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }

        public virtual ICollection<PizzaIngredient> PizzaIngredients { get; set; }
    }
}