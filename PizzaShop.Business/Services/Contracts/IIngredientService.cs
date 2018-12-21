using PizzaShop.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaShop.Business.Services
{
    public interface IIngredientService
    {
        Task<IEnumerable<IngredientModel>> GetIngredientsAsync();
    }
}