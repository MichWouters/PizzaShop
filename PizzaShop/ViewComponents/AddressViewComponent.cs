using Microsoft.AspNetCore.Mvc;
using PizzaShop.ViewModels;
using System.Threading.Tasks;

namespace PizzaShop.ViewComponents
{
    public class AddressViewComponent : ViewComponent
    {
        public AddressViewComponent()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string MyView = "Address";
            var model = new AddressViewModel();

            return View(MyView, model);
        }
    }
}