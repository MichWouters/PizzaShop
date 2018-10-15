using System.ComponentModel.DataAnnotations;

namespace PizzaShop.Data.Entities
{
    public class OrderDetail : Entity
    {
        [Key]
        public int OrderDetailID { get; set; }

        [Required]
        public virtual Pizza Pizza { get; set; }

        [Required]
        public int Amount { get; set; }

        public bool IsDelivery { get; set; }
    }
}