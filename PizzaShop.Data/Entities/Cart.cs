using System.ComponentModel.DataAnnotations;

namespace PizzaShop.Data.Entities
{
    public class Cart : Entity
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        public int PizzaId { get; set; }

        public int Quantity { get; set; }
    }
}