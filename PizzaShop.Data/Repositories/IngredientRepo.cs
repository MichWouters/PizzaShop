using Microsoft.EntityFrameworkCore;
using PizzaShop.Data.Entities;
using PizzaShop.Data.Enums;
using PizzaShop.Data.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShop.Data.Repositories
{
    public class IngredientRepo : IIngredientRepo
    {
        private readonly ApplicationDbContext _context;

        public IngredientRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddEntityAsync(Ingredient entity)
        {
            _context.Ingredients.Add(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateEntityAsync(int id, Ingredient entity)
        {
            if (entity == null)
            {
                entity = await GetEntityAsync(id);
            }

            entity.DateModified = System.DateTime.Now;
            _context.Ingredients.Update(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteEntityAsync(Ingredient entity)
        {
            _context.Ingredients.Remove(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<Ingredient> GetEntityAsync(int id)
        {
            var entity = await _context.Ingredients.FindAsync(id);
            return entity;
        }

        public async Task<IEnumerable<Ingredient>> GetAllAsync()
        {
            var result = await _context.Ingredients.ToListAsync();
            return result;
        }

        public async Task<IEnumerable<Ingredient>> GetIngredientsForPizza(int id)
        {
            IEnumerable<Ingredient> result = await _context.PizzaIngredients
                .Include(x => x.Ingredient)
                .Where(x => x.PizzaId == id)
                .Select(x => x.Ingredient).ToListAsync();

            return result;
        }

        public async Task<IEnumerable<Ingredient>> GetIngredientsForCategory(IngredientCategory ingredientType)
        {
            IEnumerable<Ingredient> result = await _context.Ingredients
                .Where(x => x.Type == (int)ingredientType)
                .ToListAsync();

            return result;
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

        public async Task<IEnumerable<object>> GetAllIngredientsPerCategory()
        {
            var viewModels = await _context.Ingredients.GroupBy(
                x => x.Type,
                (key, g) => new
                {
                    Category = (IngredientCategory)key,
                    Ingredients = _context.Ingredients.Where(y => y.Type == key).ToList()
                }).ToListAsync();

            return viewModels;
        }
    }
}