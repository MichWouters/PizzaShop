using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PizzaShop.Business.Services;
using PizzaShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaShop.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        private List<CartViewModel> _shoppingCartVm;
        private IShoppingCartService _service;

        public CartViewComponent(IShoppingCartService service)
        {
            _service = service;
        }

        public IViewComponentResult Invoke()
        {
            string MyView = "Cart";
            _shoppingCartVm = Mapper.Map<List<CartViewModel>>(_service.ShoppingCart);

            return View(MyView, _shoppingCartVm);
        }

        public void IncreaseQuantity(string name)
        {
            var currentPizza = GetCurrentItem(name);
            currentPizza.Quantity++;
            currentPizza.Price = CalculatePriceForPizza(currentPizza);
        }

        private decimal CalculatePriceForPizza(CartViewModel currentPizza, int precision = 2)
        {
            decimal price = currentPizza.Price * currentPizza.Quantity;

            return Math.Round(price, precision);
        }

        public void DecreaseQuantity(string name)
        {
            var currentPizza = GetCurrentItem(name);

            if (currentPizza.Quantity >= 1)
            {
                currentPizza.Quantity--;
                currentPizza.Price = CalculatePriceForPizza(currentPizza);
            }
        }

        private CartViewModel GetCurrentItem(string name)
        {
            int id = _shoppingCartVm.FindIndex(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            CartViewModel currentPizza = _shoppingCartVm[id];

            return currentPizza;
        }

        // Todo: Items in service!
        public void AddItemToShoppingCart(CartViewModel pizza)
        {
            throw new NotImplementedException();
        }

        public void ModifyQuantity(int id, int quantity)
        {
            throw new NotImplementedException();
        }

        public void RemoveItemFromShoppingCart()
        {
            throw new NotImplementedException();
        }

        public List<CartViewModel> GetItemsInCart()
        {
            throw new NotImplementedException();
        }
    }
}