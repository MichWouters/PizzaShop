using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaShop.Data.Entities;

namespace PizzaShop.Data.Repositories
{
    public interface IIngredientRepo
    {
        Task<int> AddEntityAsync(Ingredient entity);
        Task<int> DeleteEntityAsync(Ingredient entity);
        Task<IEnumerable<Ingredient>> GetAllAsync();
        Task<Ingredient> GetEntityAsync(int id);
        Task<IEnumerable<Ingredient>> GetIngredientsForPizza(int id);
        Task<int> PutIngredientsOnPizza(int pizzaId, int[] ingredientIds);
        Task<int> RemoveIngredientsFromPizza(int pizzaId, int[] ingredientIds);
        Task<int> UpdateEntityAsync(int id, Ingredient entity);
    }
}