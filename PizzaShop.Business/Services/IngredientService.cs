using AutoMapper;
using PizzaShop.Business.Models;
using PizzaShop.Data.Entities;
using PizzaShop.Data.Repositories.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaShop.Business.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepo _ingredientRepo;
        private readonly IMapper _mapper;

        public IngredientService(IIngredientRepo ingredientRepo, IMapper mapper)
        {
            _ingredientRepo = ingredientRepo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<IngredientModel>> GetIngredientsAsync()
        {
            IEnumerable<Ingredient> ingredients = await _ingredientRepo.GetAllAsync();
            IEnumerable<IngredientModel> ingredientModels = _mapper.Map<IEnumerable<IngredientModel>>(ingredients);

            return ingredientModels;
        }
    }
}