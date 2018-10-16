using System.ComponentModel.DataAnnotations;

namespace PizzaShop.Data.Entities
{
    public class Ingredient : Entity
    {
        [Key]
        public int IngredientId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public bool IsVegetarian { get; set; }

        public IngredientType Type { get; set; }
    }

    public enum IngredientType
    {
        Other = 0,
        Cheese = 1,
        Meat = 2,
        Fish = 3,
        Spices = 4,
        Vegetables = 5,
        Fruit = 6,
        Sauce = 7,
    }
}