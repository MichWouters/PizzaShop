using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaShop.Business.Models;
using PizzaShop.Data.Entities;
using PizzaShop.Data.Enums;
using PizzaShop.Data.Repositories.Contracts;

namespace PizzaShop.Business.Services
{
    public class IngredientsService : MappableService<Ingredient, IngredientModel>, IIngredientService
    {
        private readonly IIngredientRepo _repo;

        public IngredientsService(IIngredientRepo repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<IngredientViewModel>> GetIngredientsAsync()
        {
            IEnumerable<Ingredient> result = await _repo.GetAllAsync();

            var viewModels = result.GroupBy(
                x => x.Type,
                (category, ingredients) => new IngredientViewModel()
                {
                    Category = (IngredientCategory)category,
                    Ingredients = null
                }).ToList();

            return viewModels;
        }
    }
}