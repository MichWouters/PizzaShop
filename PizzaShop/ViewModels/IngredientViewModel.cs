using PizzaShop.Business.Models;
using PizzaShop.Data.Enums;
using System.Collections.Generic;

namespace PizzaShop.ViewModels
{
    public class IngredientViewModel
    {
        public IngredientCategory Category { get; set; }

        public IEnumerable<IngredientModel> Ingredients { get; set; }
    }
}