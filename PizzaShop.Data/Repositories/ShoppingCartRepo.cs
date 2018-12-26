using PizzaShop.Data.Entities;
using PizzaShop.Data.Repositories.Contracts;
using System;
using System.Collections.Generic;

namespace PizzaShop.Data.Repositories
{
    public class ShoppingCartRepo : IShoppingCartRepo
    {
        public IEnumerable<Cart> GetShoppingCartForUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
