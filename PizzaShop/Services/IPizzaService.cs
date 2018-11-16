using PizzaShop.Models;
using System.Threading.Tasks;

namespace PizzaShop.Services
{
    public interface IPizzaService
    {
        Task<PizzaViewModel> GetPizzaWithIngredientsAsync(int? id);

        Task SavePizza(PizzaViewModel pizzaModel);
    }
}