using PizzaShop.Data.Entities;
using System.Collections.Generic;

namespace PizzaShop.Models
{
    public class PizzaViewModel
    {

        public PizzaViewModel()
        {
        }

        public Pizza Pizza { get; set; }

        public IEnumerable<Ingredient> Ingredients { get; set; }
    }
}
