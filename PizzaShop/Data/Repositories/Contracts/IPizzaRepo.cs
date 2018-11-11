using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaShop.Data.Entities;

namespace PizzaShop.Data.Repositories
{
    public interface IPizzaRepo: IRepository<Pizza>
    {
        Task<Pizza> GetPizzaWithIngredientsAsync(int? id);
    }
}