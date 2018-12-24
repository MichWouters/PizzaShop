using Microsoft.AspNetCore.Mvc;
using PizzaShop.Business.Models;
using PizzaShop.Business.Services;
using PizzaShop.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShop.ViewComponents
{
    public class IngredientsViewComponent : ViewComponent
    {
        private readonly IIngredientService _service;

        public IngredientsViewComponent(IIngredientService service)
        {
            _service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string MyView = "Ingredients";
            IEnumerable<IngredientModel> ingredientModels = await _service.GetIngredientsAsync();
            IEnumerable<IngredientViewModel> viewModels = ingredientModels
                .GroupBy(model => model.Type)
                .Select(ingredient => new IngredientViewModel
                {
                    Category = ingredient.Key,
                    Ingredients = ingredient
                        .Where(y => y.Type == ingredient.Key)
                        .OrderBy(z => z.Name)
                        .ToList()
                });

            return View(MyView, viewModels);
        }
    }
}