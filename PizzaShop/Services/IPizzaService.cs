using PizzaShop.Models;
using PizzaShop.Data.Entities;
using System.Threading.Tasks;

namespace PizzaShop.Services
{
    public interface IPizzaService: IMappableService<Pizza, PizzaViewModel>
    {
        Task<PizzaViewModel> GetPizzaWithIngredientsAsync(int? id);

        Task SavePizza(PizzaViewModel pizzaModel);
    }
}