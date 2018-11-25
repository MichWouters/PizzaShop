using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaShop.Data.Entities
{
    public class Ingredient : Entity
    {
        public int IngredientId { get; set; }

        public string Name { get; set; }

        [Required]
        public bool IsVegetarian { get; set; }

        public ICollection<PizzaIngredient> PizzaIngredients { get; set; }

        public int Type { get; set; }
    }
}