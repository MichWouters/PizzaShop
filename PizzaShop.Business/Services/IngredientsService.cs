using PizzaShop.Business.Models;
using PizzaShop.Data.Repositories.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaShop.Business.Services
{
    public class IngredientsService : IIngredientService
    {
        private readonly IIngredientRepo _repo;

        public IngredientsService(IIngredientRepo repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<IngredientModel>> GetIngredientsAsync()
        {
            //IEnumerable<Ingredient> result = await _repo.GetAllAsync();

            //var viewModels = result.GroupBy(
            //    x => x.Type,
            //    (category, ingredients) => new IngredientModel()
            //    {
            //        Category = (IngredientCategory)category,
            //        Ingredients = MapFromEntities(ingredients)
            //    })
            //    .OrderBy(x => x.Category.ToString())
            //    .ToList();

            //return viewModels;

            throw new System.NotImplementedException();
        }
    }
}