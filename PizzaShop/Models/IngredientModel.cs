using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaShop.Data.Enums;

namespace PizzaShop.Models
{
    public class IngredientModel: Model
    {
        public int ID  { get; set; }

        public string Name { get; set; }

        public bool IsVegetarian { get; set; }

        public IngredientCategory Type { get; set; }

        public bool IsOnPizza  { get; set; }

    }
}
