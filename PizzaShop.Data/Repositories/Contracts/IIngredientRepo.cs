using PizzaShop.Data.Entities;
using PizzaShop.Data.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaShop.Data.Repositories.Contracts
{
    public interface IIngredientRepo : IRepository<Ingredient>
    {
        Task<IEnumerable<Ingredient>> GetIngredientsForPizza(int id);

        Task<IEnumerable<Ingredient>> GetIngredientsForCategory(IngredientCategory ingredientType);

        Task<int> PutIngredientsOnPizza(int pizzaId, int[] ingredientIds);

        Task<int> RemoveIngredientsFromPizza(int pizzaId, int[] ingredientIds);
    }
}