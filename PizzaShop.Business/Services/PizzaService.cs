﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using PizzaShop.Business.Models;
using PizzaShop.Data.Entities;
using PizzaShop.Data.Repositories.Contracts;

namespace PizzaShop.Business.Services
{
    public class PizzaService : MappableService<Pizza, PizzaViewModel>, IPizzaService
    {
        private readonly IPizzaRepo _pizzaRepo;
        private readonly IIngredientRepo _ingredientRepo;

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

            int verifiedId = (int) id;
            Pizza pizza = await _pizzaRepo.GetEntityAsync(verifiedId);
            PizzaViewModel pizzaModel = MapFromEntity(pizza);
            pizzaModel = (PizzaViewModel)pizzaModel.ConvertUnmappableValues();

            pizzaModel.Ingredients = await _ingredientRepo.GetIngredientsForPizza(verifiedId);

            return pizzaModel;
        }

        public async Task SavePizza(PizzaViewModel pizzaModel)
        {
            var pizza = MapToEntity(pizzaModel);

            // Todo: Verify security checks

            using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
            {
                int pizzaRows = await _pizzaRepo.AddEntityAsync(pizza);
                int ingredientRows = await _ingredientRepo.PutIngredientsOnPizza(
                    pizzaModel.PizzaId,
                    pizzaModel.Ingredients.Select(x => x.IngredientId).ToArray());

                Console.WriteLine(pizzaRows);
                Console.WriteLine(ingredientRows);

                // Commit transaction if all commands succeed, transaction will auto-rollback
                // when disposed if either commands fails
                scope.Complete();
            }
        }
    }
}