using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaShop.Business.Models;

namespace PizzaShop.Business.Services
{
    public interface IIngredientService
    {
        Task<IEnumerable<IngredientModel>> GetIngredientsAsync();
    }
}