using AutoMapper;
using PizzaShop.Business.Models;
using PizzaShop.Data.Entities;
using PizzaShop.Data.Repositories.Contracts;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaShop.Business.Services
{
    public class IngredientService : IIngredientService
    {
        private IIngredientRepo _ingredientRepo;

        public IngredientService(IIngredientRepo ingredientRepo)
        {
            _ingredientRepo = ingredientRepo;
        }

        public async Task<IEnumerable<IngredientModel>> GetIngredientsAsync()
        {
            IEnumerable<Ingredient> ingredients = await _ingredientRepo.GetAllAsync();
            IEnumerable<IngredientModel> ingredientModels = Mapper.Map<IEnumerable<IngredientModel>>(ingredients);

            return ingredientModels;
        }
    }
}