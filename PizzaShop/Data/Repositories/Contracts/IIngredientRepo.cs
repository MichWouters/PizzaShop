using PizzaShop.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaShop.Data.Repositories
{
    public interface IIngredientRepo : IRepository<Ingredient>
    {
        Task<IEnumerable<Ingredient>> GetIngredientsForPizza(int id);
    }
}