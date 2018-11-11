using System.Threading.Tasks;
using PizzaShop.Models;

namespace PizzaShop.Services
{
    public interface IPizzaService
    {
        Task<PizzaViewModel> GetPizzaWithIngredientsAsync(int? id);
    }
}