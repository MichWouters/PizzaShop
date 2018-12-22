using PizzaShop.Business.Models;

namespace PizzaShop.ViewModels
{
    public class CartViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}