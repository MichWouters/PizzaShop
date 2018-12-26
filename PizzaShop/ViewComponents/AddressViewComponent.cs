using Microsoft.AspNetCore.Mvc;
using PizzaShop.ViewModels;

namespace PizzaShop.ViewComponents
{
    public class AddressViewComponent : ViewComponent
    {
        public AddressViewComponent()
        {
        }

        public IViewComponentResult Invoke()
        {
            string MyView = "Address";
            var model = new AddressViewModel();

            return View(MyView, model);
        }
    }
}