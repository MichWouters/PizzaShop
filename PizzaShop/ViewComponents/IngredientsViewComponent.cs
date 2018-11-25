using Microsoft.AspNetCore.Mvc;
using PizzaShop.Data.Entities;
using PizzaShop.Data.Repositories;
using PizzaShop.Models;
using System.Collections.Generic;
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
            var ingredients = new List<IngredientViewModel>();
            
            IEnumerable<Ingredient> result = await _repo.GetAllAsync();
            

            return ingredients;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string MyView = "Ingredients";
            var items = await GetIngredientsAsync();

            return View(MyView, items);
        }
    }
}