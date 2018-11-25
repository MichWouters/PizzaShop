using System.Threading.Tasks;
using PizzaShop.Data.Entities;

namespace PizzaShop.Data.Repositories.Contracts
{
    public interface IPizzaRepo : IRepository<Pizza>
    {
        Task<Pizza> GetPizzaWithIngredientsAsync(int? id, bool includeIngredientData = false);
    }
}