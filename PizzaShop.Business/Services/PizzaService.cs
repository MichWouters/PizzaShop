using System;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using AutoMapper;
using PizzaShop.Business.Models;
using PizzaShop.Data.Entities;
using PizzaShop.Data.Repositories.Contracts;

namespace PizzaShop.Business.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly IPizzaRepo _pizzaRepo;
        private readonly IIngredientRepo _ingredientRepo;

        public PizzaService(IPizzaRepo pizzaRepo, IIngredientRepo ingredientRepo)
        {
            _pizzaRepo = pizzaRepo;
            _ingredientRepo = ingredientRepo;
        }

        public async Task<PizzaModel> GetPizzaWithIngredientsAsync(int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException(nameof(id));
            }

            int verifiedId = id;
            Pizza pizza = await _pizzaRepo.GetEntityAsync(verifiedId);
            PizzaModel pizzaModel = new PizzaModel();
            pizzaModel = Mapper.Map(pizza, pizzaModel);
            
            return pizzaModel;
        }

        public async Task SavePizza(PizzaModel pizzaModel)
        {
            Pizza pizzaEntity = Mapper.Map<Pizza>(pizzaModel);

            // Todo: Verify security checks

            using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
            {
                int pizzaRows = await _pizzaRepo.AddEntityAsync(pizzaEntity);
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