﻿using PizzaShop.Data.Repositories;
using PizzaShop.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShop.Services
{
    public class PizzaService : IPizzaService
    {
        private IPizzaRepo _pizzaRepo;
        private IIngredientRepo _ingredientRepo;

        public PizzaService(IPizzaRepo pizzaRepo, IIngredientRepo ingredientRepo)
        {
            _pizzaRepo = pizzaRepo;
            _ingredientRepo = ingredientRepo;
        }

        public async Task<PizzaViewModel> GetPizzaWithIngredientsAsync(int? id)
        {
            if (id == null || id == 0)
            {
                throw new ArgumentNullException(nameof(id));
            }

            int verifiedId = id?? default(int);

            var model = new PizzaViewModel
            {
                Pizza = await _pizzaRepo.GetPizzaWithIngredientsAsync(verifiedId)
            };

            if (model.Pizza.PizzaIngredients == null || model.Pizza.PizzaIngredients.Count == 0 )
            {
                model.Ingredients = await _ingredientRepo.GetIngredientsForPizza(verifiedId);
            }
            else
            {
                model.Ingredients = model.Pizza.PizzaIngredients.Select(x => x.Ingredient).ToList();
            }

            return model;
        }
    }
}
