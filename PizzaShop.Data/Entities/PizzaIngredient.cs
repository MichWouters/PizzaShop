using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaShop.Data.Entities
{
    public class PizzaIngredient
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("PizzaRefId")]
        [Required]
        public int PizzaId { get; set; }

        public virtual Pizza Pizza { get; set; }

        [ForeignKey("PizzaRefId")]
        [Required]
        public int IngredientId { get; set; }

        public virtual Ingredient Ingredient { get; set; }
    }
}