using PizzaShop.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaShop.Services
{
    public interface IIngredientService
    {
        Task<IEnumerable<IngredientViewModel>> GetIngredientsAsync();
    }
}