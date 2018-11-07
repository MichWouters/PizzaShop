using PizzaShop.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PizzaShop.Data.Repositories
{
    public class IngredientRepo : IIngredientRepo
    {
        private readonly ApplicationDbContext _context;

        public IngredientRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public int AddEntity(Ingredient entity)
        {
            _context.Ingredients.Add(entity);
            return _context.SaveChanges();
        }

        public int DeleteEntity(Ingredient entity)
        {
            _context.Ingredients.Remove(entity);
            return _context.SaveChanges();
        }

        public IEnumerable<Ingredient> GetAll()
        {
            var result = _context.Ingredients.ToList();
            return result;
        }

        public Ingredient GetEntity(int id)
        {
            var entity = _context.Ingredients.Find(id);
            return entity;
        }

        public int UpdateEntity(int id, Ingredient entity)
        {
            if (entity == null)
            {
                entity = GetEntity(id);
            }

            entity.DateModified = System.DateTime.Now;
            _context.Ingredients.Update(entity);
            return _context.SaveChanges();
        }

        IEnumerable<Ingredient> IIngredientRepo.GetIngredientsForPizza(int id)
        {
            var result = _context.Ingredients.Join(_context.Pizzas.Where(x => x.PizzaId == id),
                x => x.IngredientId,
                y => y.PizzaId, (y, x) => y)
                .ToList();

            return null;
        }
    }
}
