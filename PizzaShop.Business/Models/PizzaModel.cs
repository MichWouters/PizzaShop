using System.Collections.Generic;
using PizzaShop.Data.Entities;

namespace PizzaShop.Business.Models
{
    public class PizzaModel : Model
    {
        public int PizzaId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public decimal Price { get; set; }

        public IEnumerable<Ingredient> Ingredients { get; set; }

        public bool IsAvailable { get; set; }
    }
}