using Microsoft.EntityFrameworkCore;
using PizzaShop.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PizzaShop.Data.Repositories
{
    public class PizzaRepo : IPizzaRepo
    {
        private readonly ApplicationDbContext _context;

        public PizzaRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public int AddEntity(Pizza entity)
        {
            _context.Pizzas.Add(entity);
            return _context.SaveChanges();
        }

        public int DeleteEntity(Pizza entity)
        {
            _context.Pizzas.Remove(entity);
            return _context.SaveChanges();
        }

        public IEnumerable<Pizza> GetAll()
        {
            var pizzas = _context.Pizzas.ToList();
            return pizzas;
        }

        public Pizza GetEntity(int id)
        {
            Pizza entity = _context.Pizzas.Find(id);
            return entity;
        }

        public Pizza GetPizzaWithIngredients(int id)
        {
            Pizza entity = _context.Pizzas.Include(pizza => pizza.PizzaIngredients)
                .ThenInclude(ingredient => ingredient.Ingredient)
                .Where(x => x.PizzaId == id)
                .First();
            return entity;
        }

        public int UpdateEntity(int id, Pizza entity)
        {
            if (entity == null)
            {
                entity = GetEntity(id);
            }

            entity.DateModified = System.DateTime.Now;
            _context.Pizzas.Update(entity);
            return _context.SaveChanges();
        }
    }
}