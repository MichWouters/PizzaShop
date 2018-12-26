using PizzaShop.Data.Entities;
using System.Collections.Generic;

namespace PizzaShop.Data.Repositories.Contracts
{
    public interface IShoppingCartRepo
    {
        IEnumerable<Cart> GetShoppingCartForUser(int userId);
    }
}