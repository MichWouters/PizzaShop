using Microsoft.EntityFrameworkCore;
using PizzaShop.Data.Entities;
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

        public async Task<int> DeleteEntityAsync(Ingredient entity)
        {
            _context.Ingredients.Remove(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Ingredient>> GetAllAsync()
        {
            var result = await _context.Ingredients.ToListAsync();
            return result;
        }

        public async Task<Ingredient> GetEntityAsync(int id)
        {
            var entity = await _context.Ingredients.FindAsync(id);
            return entity;
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

        public async Task<IEnumerable<Ingredient>> GetIngredientsForPizza(int id)
        {
            IEnumerable<Ingredient> result = await _context.PizzaIngredients
                .Include(x => x.Ingredient)
                .Where(x => x.PizzaId == id)
                .Select(x => x.Ingredient).ToListAsync();

            return null;
        }
    }
}
