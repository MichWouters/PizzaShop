using System.Threading.Tasks;
using PizzaShop.Business.Models;

namespace PizzaShop.Business.Services
{
    public interface IPizzaService
    {
        Task<PizzaModel> GetPizzaWithIngredientsAsync(int? id);

        Task SavePizza(PizzaModel pizzaModel);
    }
}