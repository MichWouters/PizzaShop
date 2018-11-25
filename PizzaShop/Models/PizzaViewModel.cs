﻿using PizzaShop.Data.Entities;
using System.Collections.Generic;

namespace PizzaShop.Models
{
    public class PizzaViewModel : Model
    {
        public int PizzaId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public decimal Price { get; set; }

        public IEnumerable<Ingredient> Ingredients { get; set; }

        public bool IsAvailable { get; set; }

        public override Model ConvertUnmappableValues()
        {
            Image = "../../Images/" + Image;
            return this;
        }
    }
}