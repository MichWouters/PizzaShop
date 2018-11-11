using Microsoft.EntityFrameworkCore;
using PizzaShop.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShop.Data.Repositories
{
    public class PizzaRepo : IPizzaRepo
    {
        private readonly ApplicationDbContext _context;

        public PizzaRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddEntity(Pizza entity)
        {
            _context.Pizzas.Add(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteEntity(Pizza entity)
        {
            _context.Pizzas.Remove(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Pizza>> GetPizzasAsync()
        {
            var pizzas = await _context.Pizzas.ToListAsync();
            return pizzas;
        }

        public async Task<Pizza> GetEntityAsync(int id)
        {
            Pizza entity = await _context.Pizzas.FindAsync(id);
            return entity;
        }

        public async Task<Pizza> GetPizzaWithIngredientsAsync(int? id)
        {
            Pizza entity = await _context.Pizzas.Include(pizza => pizza.PizzaIngredients)
                .ThenInclude(ingredient => ingredient.Ingredient)
                .Where(x => x.PizzaId == id)
                .FirstOrDefaultAsync();
            return entity;
        }

        public async Task<int> UpdateEntity(int id, Pizza entity)
        {
            if (entity == null)
            {
                entity = await GetEntityAsync(id);
            }

            entity.DateModified = System.DateTime.Now;
            _context.Pizzas.Update(entity);
            return await _context.SaveChangesAsync();
        }
    }
}