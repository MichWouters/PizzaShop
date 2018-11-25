﻿using System.Collections.Generic;
using PizzaShop.Data.Enums;

namespace PizzaShop.Business.Models
{
    public class IngredientViewModel : Model
    {
        public IngredientCategory Category { get; set; }

        public List<IngredientModel> Ingredients { get; set; }

    }
}