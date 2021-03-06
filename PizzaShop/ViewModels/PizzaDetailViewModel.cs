﻿using System.ComponentModel.DataAnnotations;

namespace PizzaShop.ViewModels
{
    public class PizzaDetailViewModel
    {
        public int PizzaId { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Image { get; set; }

        [Range(3.99, 19.99)]
        public decimal Price { get; set; }

        [MinLength(2)]
        public string[] Ingredients { get; set; }
    }
}