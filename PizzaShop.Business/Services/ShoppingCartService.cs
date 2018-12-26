using AutoMapper;
using PizzaShop.Business.Models;
using PizzaShop.Data.Entities;
using PizzaShop.Data.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaShop.Business.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private List<CartModel> _shoppingCart;

        private readonly IShoppingCartRepo _repo;

        public ShoppingCartService(IShoppingCartRepo repo)
        {
            _repo = repo;
        }

        public IEnumerable<CartModel> GetItemsInCart()
        {
            return _shoppingCart;
        }

        public int AddItemToCart(CartModel model)
        {
            try
            {
                _shoppingCart.Add(model);
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int RemoveItemFromCart(CartModel model)
        {
            try
            {
                int amountRemoved = (_shoppingCart.Remove(model)) ? 1 : 0;
                return amountRemoved;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int ClearCart(CartModel model)
        {
            throw new NotImplementedException();
        }

        public double CalculateTotal(IEnumerable<CartModel> model)
        {
            throw new NotImplementedException();
        }

        public int GetAmountOfItemsInCart()
        {
            return _shoppingCart.Count;
        }

        public void InitializeCart()
        {
            _shoppingCart = GetShoppingCartForUser().ToList();
        }

        private IEnumerable<CartModel> GetShoppingCartForUser()
        {
            IEnumerable<Cart> cart = _repo.GetShoppingCartForUser(-1);
            var cartModel = Mapper.Map<IEnumerable<CartModel>>(cart);

            return cartModel;
        }
    }
}