﻿using PizzaShop.Data.Entities;
using PizzaShop.Data.Enums;
using System.Collections.Generic;

namespace PizzaShop.Models
{
    public class IngredientViewModel : Model
    {
        public IngredientCategory Category { get; set; }

        public List<Ingredient> Ingredients { get; set; }
    }
}