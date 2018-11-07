using PizzaShop.Data.Repositories;
using PizzaShop.Models;
using System.Linq;

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

            if (model.Pizza.PizzaIngredients == null || model.Pizza.PizzaIngredients.Count == 0 )
            {
                model.Ingredients = _ingredientRepo.GetIngredientsForPizza(id);
            }
            else
            {
                model.Ingredients = model.Pizza.PizzaIngredients.Select(x => x.Ingredient).ToList();
            }

            return model;
        }
    }
}
