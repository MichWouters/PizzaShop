using Moq;
using PizzaShop.Data.Entities;
using PizzaShop.Data.Repositories;
using PizzaShop.Models;
using PizzaShop.Services;
using System.Collections.Generic;
using Xunit;

namespace PizzaShop.Testing
{
    public class PizzaTests
    {
        private IPizzaService _service;
        private Mock<IIngredientRepo> mockIngredientRepo;
        private Mock<IPizzaRepo> mockPizzaRepo;

        public PizzaTests()
        {
            var mockPizzaRepo = new Mock<IPizzaRepo>();
            var mockIngredientRepo = new Mock<IIngredientRepo>();
            _service = new PizzaService(mockPizzaRepo.Object, mockIngredientRepo.Object);
        }

        [Fact]
        public async void Can_Map_Pizza_From_Entity()
        {
            // Arrange

            var mockPizza = new PizzaViewModel
            {
                Name = "TestPizza",
                Price = 5.14,
                Ingredients = new List<Ingredient>
                {
                    new Ingredient{ IngredientId = 1 , },
                    new Ingredient{ IngredientId = 2},
                    new Ingredient{ IngredientId = 3}
                }
            };

            await _service.SavePizza(mockPizza);
            mockPizzaRepo.Verify(p => p.AddEntityAsync(It.IsAny<Pizza>()));
        }
    }
}