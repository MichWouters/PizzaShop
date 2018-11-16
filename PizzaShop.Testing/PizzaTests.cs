using System;
using Xunit;
using Moq;
using PizzaShop.Data.Repositories;
using PizzaShop.Services;
using PizzaShop.Data.Entities;
using System.Collections.Generic;

namespace PizzaShop.Testing
{
    public class PizzaTests
    {
        private IPizzaService _service;

        public PizzaTests()
        {
           
        }

        [Fact]
        public async void Can_Map_Pizza_From_Entity()
        {
            // Arrange
            var mockPizzaRepo = new Mock<IPizzaRepo>();
            var mockIngredientRepo = new Mock<IIngredientRepo>();
            _service = new PizzaService(mockPizzaRepo.Object, mockIngredientRepo.Object);
            var mockPizza = new Pizza
            {
                Name = "TestPizza",
                Price = 5.14,
                PizzaIngredients = new List<PizzaIngredient>
                {
                    new PizzaIngredient{ IngredientId = 1},
                    new PizzaIngredient{ IngredientId = 2},
                    new PizzaIngredient{ IngredientId = 3}
                }
            };

            mockPizzaRepo.Setup(x => x.GetPizzaWithIngredientsAsync(It.IsAny<int>(), false)).ReturnsAsync(mockPizza);

            var pizza = await mockPizzaRepo.Object.GetPizzaWithIngredientsAsync(3);

        }
    }
}
