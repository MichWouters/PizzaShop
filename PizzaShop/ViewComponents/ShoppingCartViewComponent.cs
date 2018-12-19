using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShop.ViewComponents
{
    public class ShoppingCartViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string MyView = "Ingredients";
            var items = await _service.GetIngredientsAsync();

            return View(MyView, items);
        }
    }
}
