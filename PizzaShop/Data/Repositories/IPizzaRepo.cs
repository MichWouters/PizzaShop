using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaShop.Data.Entities;

namespace PizzaShop.Data.Repositories
{
    public interface IPizzaRepo
    {
        Task<int> AddEntity(Pizza entity);
        Task<int> DeleteEntity(Pizza entity);
        Task<Pizza> GetEntityAsync(int id);
        Task<IEnumerable<Pizza>> GetPizzasAsync();
        Task<Pizza> GetPizzaWithIngredientsAsync(int? id);
        Task<int> UpdateEntity(int id, Pizza entity);
    }
}