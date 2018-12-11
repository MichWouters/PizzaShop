using PizzaShop.Data.Entities;
using System.Collections.Generic;

namespace PizzaShop.Business.Models
{
    public class PizzaModel : Model
    {
        public int PizzaId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public decimal Price { get; set; }

        public decimal VAT { get; set; }

        public IEnumerable<Ingredient> Ingredients { get; set; }

        public bool IsAvailable { get; set; }
    }
}