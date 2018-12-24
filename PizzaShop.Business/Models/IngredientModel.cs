using PizzaShop.Data.Enums;

namespace PizzaShop.Business.Models
{
    public class IngredientModel : Model
    {
        public int IngredientId { get; set; }

        public string Name { get; set; }

        public bool IsVegetarian { get; set; }

        public IngredientCategory Type { get; set; }

        public bool IsOnPizza { get; set; }
    }
}