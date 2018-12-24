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
            var viewModels = from x in ingredientModels
                             group x by x.Type into g
                             select new IngredientViewModel
                             {
                                 Category = g.Key,
                                 Ingredients = g.Where(y => y.Type == g.Key).ToList()
                             };

            return View(MyView, viewModels);
        }
    }
}