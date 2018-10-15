using System.ComponentModel.DataAnnotations;

namespace PizzaShop.Data.Entities
{
    public class Ingredient : Entity
    {
        [Key]
        public int IngredientID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public bool IsVegetarian { get; set; }
    }
}