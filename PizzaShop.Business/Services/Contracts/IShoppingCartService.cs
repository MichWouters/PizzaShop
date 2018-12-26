using PizzaShop.Business.Models;
using System.Collections.Generic;

namespace PizzaShop.Business.Services
{
    public interface IShoppingCartService
    {
        IEnumerable<CartModel> GetItemsInCart();

        int AddItemToCart(CartModel model);

        int RemoveItemFromCart(CartModel model);

        int ClearCart(CartModel model);

        double CalculateTotal(IEnumerable<CartModel> model);

        int GetAmountOfItemsInCart();

        void InitializeCart();
    }
}