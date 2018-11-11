using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaShop.Data.Entities;

namespace PizzaShop.Data.Repositories
{
    public interface IIngredientRepo: IRepository<Ingredient>
    {
        Task<IEnumerable<Ingredient>> GetIngredientsForPizza(int id);
    }
}