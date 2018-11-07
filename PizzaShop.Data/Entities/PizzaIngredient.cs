using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PizzaShop.Data.Entities
{
    public class PizzaIngredient
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("PizzaRefId")]
        public int PizzaId { get; set; }

        public virtual Pizza Pizza { get; set; }

        [ForeignKey("PizzaRefId")]
        public int IngredientId { get; set; }

        public virtual Ingredient Ingredient { get; set; }
    }
}
