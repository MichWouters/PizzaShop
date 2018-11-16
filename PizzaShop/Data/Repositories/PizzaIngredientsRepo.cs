using PizzaShop.Data.Entities;
using System.Threading.Tasks;

namespace PizzaShop.Data.Repositories
{
    public class PizzaIngredientsRepo : IPizzaIngredientsRepo
    {
        private readonly ApplicationDbContext _context;

        public PizzaIngredientsRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> PutIngredientsOnPizza(int pizzaId, int[] ingredientIds)
        {
            for (int i = 0; i < ingredientIds.Length; i++)
            {
                _context.PizzaIngredients.Add(
                    new PizzaIngredient { PizzaId = pizzaId, IngredientId = ingredientIds[i] });
            }

            return await _context.SaveChangesAsync();
        }

        public async Task<int> RemoveIngredientsFromPizza(int pizzaId, int[] ingredientIds)
        {
            for (int i = 0; i < ingredientIds.Length; i++)
            {
                _context.PizzaIngredients.Remove(
                    new PizzaIngredient { PizzaId = pizzaId, IngredientId = ingredientIds[i] });
            }

            return await _context.SaveChangesAsync();
        }
    }
}