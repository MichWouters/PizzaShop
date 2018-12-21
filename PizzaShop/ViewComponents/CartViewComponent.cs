using Microsoft.AspNetCore.Mvc;
using PizzaShop.Business.Models;
using PizzaShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaShop.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        private List<CartItem> _shoppingCart;

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string MyView = "Cart";
            _shoppingCart = GetMockItems();
            return View(MyView, _shoppingCart);
        }

        private List<CartItem> GetMockItems()
        {
            var list = new List<CartItem>(){
                new CartItem
                {
                    Pizza = new PizzaModel
                    {
                        Name = "Forestiere",
                        Price = 12.25M
                    },
                    Quantity = 3
                },
                new CartItem
                {
                    Pizza = new PizzaModel
                    {
                        Name = "Pepperoni Lovers",
                        Price = 12.25M
                    },
                    Quantity = 3
                }
            };
            return list;
        }

        // Todo: Items in service!
        public void AddItemToShoppingCart(CartItem pizza)
        {
            _shoppingCart.Add(pizza);
        }

        public void ModifyQuantity(int id, int quantity)
        {
            throw new NotImplementedException();
        }

        public void RemoveItemFromShoppingCart()
        {
            throw new NotImplementedException();
        }

        public List<CartItem> GetItemsInCart()
        {
            throw new NotImplementedException();
        }
    }
}