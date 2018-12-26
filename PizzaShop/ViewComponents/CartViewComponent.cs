using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PizzaShop.Business.Models;
using PizzaShop.Business.Services;
using PizzaShop.ViewModels;
using System;
using System.Collections.Generic;

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
            var models = this.GetItemsInCart();
            _shoppingCartVm = Mapper.Map<List<CartViewModel>>(models);

            return View(MyView, _shoppingCartVm);
        }

        private decimal CalculatePriceForPizza(CartViewModel currentPizza, int precision = 2)
        {
            decimal price = currentPizza.Price * currentPizza.Quantity;

            return Math.Round(price, precision);
        }

        public void IncreaseQuantity(string name)
        {
            var currentPizza = GetCurrentItem(name);
            currentPizza.Quantity++;
            currentPizza.Price = CalculatePriceForPizza(currentPizza);
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

        public void AddItemToShoppingCart(CartViewModel vm)
        {
            CartModel model = Mapper.Map<CartModel>(vm);
            _service.AddItemToCart(model);
        }

        public void RemoveItemFromShoppingCart(CartViewModel vm)
        {
            CartModel model = Mapper.Map<CartModel>(vm);
            _service.RemoveItemFromCart(model);
        }

        public List<CartViewModel> GetItemsInCart()
        {
            // TODO
            return new List<CartViewModel>();
        }
    }
}