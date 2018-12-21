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

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string MyView = "Cart";
            _shoppingCartVm = GetMockItems();
            return View(MyView, _shoppingCartVm);
        }

        

        // Todo: Items in service!
        public void AddItemToShoppingCart(CartViewModel pizza)
        {
            _shoppingCartVm.Add(pizza);
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