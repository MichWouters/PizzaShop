using System.Collections.Generic;
using PizzaShop.Data.Entities;

namespace PizzaShop.Data.Repositories
{
    public interface IIngredientRepo: IRepository<Ingredient>
    {
        IEnumerable<Ingredient> GetIngredientsForPizza(int id);
    }
}