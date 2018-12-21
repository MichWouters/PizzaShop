using PizzaShop.Business.Models;
using System.Threading.Tasks;

namespace PizzaShop.Business.Services
{
    public interface IPizzaService
    {
        Task<PizzaModel> GetPizzaWithIngredientsAsync(int id);

        Task SavePizza(PizzaModel pizzaModel);
    }
}