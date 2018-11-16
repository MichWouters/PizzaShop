using System.Collections.Generic;
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

        public ICollection<PizzaIngredient> PizzaIngredients { get; set; }

        [EnumDataType(typeof(IngredientType))]
        public IngredientType Type { get; set; }
    }

    public enum IngredientType
    {
        Other = 0,
        Cheese = 1,
        Meat = 2,
        Fish = 3,
        Condiments = 4,
        Vegetables = 5,
        Fruit = 6,
        Sauce = 7,
        Herbs = 8
    }
}