using PizzaShop.Business.Models;

namespace PizzaShop.ViewModels
{
    public class CartItem
    {
        public PizzaModel Pizzas{ get; set; }

        public int Quantity { get; set; }
    }
}
