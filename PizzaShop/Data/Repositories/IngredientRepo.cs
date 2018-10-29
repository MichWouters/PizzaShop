using PizzaShop.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PizzaShop.Data.Repositories
{
    public class IngredientRepo : IRepository<Ingredient>
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

            _context.Ingredients.Update(entity);
            return _context.SaveChanges();
        }
    }
}
