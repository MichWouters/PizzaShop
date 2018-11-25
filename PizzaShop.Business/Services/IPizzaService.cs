using System.Threading.Tasks;
using PizzaShop.Business.Models;

namespace PizzaShop.Business.Services
{
    public interface IPizzaService
    {
        Task<PizzaViewModel> GetPizzaWithIngredientsAsync(int? id);

        Task SavePizza(PizzaViewModel pizzaModel);
    }
}