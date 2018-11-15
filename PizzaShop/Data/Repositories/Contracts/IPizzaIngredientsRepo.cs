using PizzaShop.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaShop.Data.Repositories
{
    public interface IPizzaIngredientsRepo
    {
        Task<int> PutIngredientsOnPizza(int pizzaId, int[] ingredientIds);

        Task<int> RemoveIngredientsFromPizza(int pizzaId, int[] ingredientIds);

        Task<IEnumerable<Ingredient>> GetIngredientsForPizza(int id);
    }
}