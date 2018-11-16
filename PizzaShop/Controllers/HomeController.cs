using Microsoft.AspNetCore.Mvc;
using PizzaShop.Models;
using PizzaShop.Services;
using System.Diagnostics;

namespace PizzaShop.Controllers
{
    public class HomeController : Controller
    {
        private IPizzaService _service;

        public HomeController(IPizzaService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var pizza = _service.GetPizzaWithIngredientsAsync(3);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}