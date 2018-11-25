using Microsoft.AspNetCore.Mvc;
using PizzaShop.Data.Entities;
using PizzaShop.Data.Enums;
using PizzaShop.Data.Repositories.Contracts;
using PizzaShop.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShop.ViewComponents
{
    public class IngredientsViewComponent : ViewComponent
    {
        private readonly IIngredientRepo _repo;

        public IngredientsViewComponent(IIngredientRepo repo)
        {
            _repo = repo;
        }

        private async Task<IEnumerable<IngredientViewModel>> GetIngredientsAsync()
        {
            IEnumerable<Ingredient> result = await _repo.GetAllAsync();

            var viewModels = result.GroupBy(
                x => x.Type,
                (category, ingredients) => new IngredientViewModel()
                {
                    Category = (IngredientCategory)category,
                    Ingredients = (ingredients).ToList()
                }).ToList();

            return viewModels;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string MyView = "Ingredients";
            var items = await GetIngredientsAsync();

            return View(MyView, items);
        }
    }
}