using PizzaShop.Business.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PizzaShop.Business.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private ObservableCollection<CartModel> _shoppingCart;

        public ObservableCollection<CartModel> ShoppingCart
        {
            get { return _shoppingCart; }
            set { _shoppingCart = value; }
        }

        public ShoppingCartService()
        {
            ShoppingCart = new ObservableCollection<CartModel>(GetMockItems());
        }

        private IEnumerable<CartModel> GetMockItems()
        {
            var list = new List<CartModel>(){
                new CartModel
                {
                    Pizza = new PizzaModel
                    {
                        Name = "Forestiere",
                        Price = 12.25M
                    },
                    Quantity = 3
                },
                new CartModel
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
    }
}
