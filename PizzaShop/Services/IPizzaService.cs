using PizzaShop.Models;

namespace PizzaShop.Services
{
    public interface IPizzaService
    {
        PizzaViewModel GetPizzaWithIngredients(int id);
    }
}