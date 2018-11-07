using PizzaShop.Data.Repositories;
using PizzaShop.Models;

namespace PizzaShop.Services
{
    public class PizzaService : IPizzaService
    {
        private IPizzaRepo _pizzaRepo;
        private IIngredientRepo _ingredientRepo;

        public PizzaService(IPizzaRepo pizzaRepo, IIngredientRepo ingredientRepo)
        {
            _pizzaRepo = pizzaRepo;
            _ingredientRepo = ingredientRepo;
        }

        public PizzaViewModel GetPizzaWithIngredients(int id)
        {
            PizzaViewModel model = new PizzaViewModel();
            model.Pizza = _pizzaRepo.GetPizzaWithIngredients(id);
            model.Ingredients = _ingredientRepo.GetIngredientsForPizza(id);

            return model;
        }
    }
}
