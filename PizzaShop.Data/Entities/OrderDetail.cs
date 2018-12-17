using System.ComponentModel.DataAnnotations;

namespace PizzaShop.Data.Entities
{
    public class OrderDetail : Entity
    {
        [Key]
        public int OrderDetailId { get; set; }

        public virtual Pizza Pizza { get; set; }

        public int Amount { get; set; }
    }
}