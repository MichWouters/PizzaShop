using PizzaShop.Business.Models;

namespace PizzaShop.ViewModels
{
    public class CartItem
    {
        public int Id { get; set; }

        public PizzaModel Pizza { get; set; }

        public int Quantity { get; set; }
    }
}