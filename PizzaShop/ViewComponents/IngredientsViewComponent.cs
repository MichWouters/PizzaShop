using Microsoft.AspNetCore.Mvc;
using PizzaShop.Business.Services;
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
            var items = await _service.GetIngredientsAsync();

            return View(MyView, items);
        }
    }
}