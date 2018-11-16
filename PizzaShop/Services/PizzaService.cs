using AutoMapper;
using AutoMapper.Configuration;
using PizzaShop.Data.Entities;
using PizzaShop.Data.Repositories;
using PizzaShop.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace PizzaShop.Services
{
    public class PizzaService : MappableService<Pizza, PizzaViewModel>, IPizzaService
    {
        private readonly IPizzaRepo _pizzaRepo;
        private readonly IPizzaIngredientsRepo _ingredientRepo;

        public PizzaService(IPizzaRepo pizzaRepo, IPizzaIngredientsRepo ingredientRepo)
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

            int verifiedId = id ?? default(int);
            var pizza = await _pizzaRepo.GetPizzaWithIngredientsAsync(verifiedId);
            var pizzaModel = MapFromEntity(pizza);

            var model = new PizzaViewModel
            {
            };

            model.Ingredients = await _ingredientRepo.GetIngredientsForPizza(verifiedId);

            return model;
        }

        public async Task SavePizza(PizzaViewModel pizzaModel)
        {
            var pizza = MapToEntity(pizzaModel);

            using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
            {
                int pizzaRows = await _pizzaRepo.AddEntityAsync(pizza);
                int ingredientRows = await _ingredientRepo.PutIngredientsOnPizza(
                    pizzaModel.PizzaId,
                    pizzaModel.Ingredients.Select(x => x.IngredientId).ToArray());

                // Commit transaction if all commands succeed, transaction will auto-rollback
                // when disposed if either commands fails
                scope.Complete();

            }
        }
    }
}