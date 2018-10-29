using PizzaShop.Data.Repositories;
using Xunit;
using PizzaShop.Services;

namespace PizzaShop.Testing
{
    public class PizzaTests
    {
        private IPizzaService _service;

        public PizzaTests(IPizzaRepo pizzaRepo, IIngredientRepo ingredientRepo)
        {
            _service = new PizzaService(pizzaRepo, ingredientRepo);
        }

        [Fact]
        public void Test1()
        {
            _service.GetPizzaWithIngredients(3);
        }
    }
}
