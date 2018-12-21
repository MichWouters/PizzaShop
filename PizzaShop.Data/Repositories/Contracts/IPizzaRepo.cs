using PizzaShop.Data.Entities;
using System.Threading.Tasks;

namespace PizzaShop.Data.Repositories.Contracts
{
    public interface IPizzaRepo : IRepository<Pizza>
    {
        Task<Pizza> GetPizzaWithIngredientsAsync(int? id, bool includeIngredientData = false);
    }
}