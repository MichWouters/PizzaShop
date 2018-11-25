using Moq;
using PizzaShop.Data.Entities;
using PizzaShop.Data.Repositories;
using PizzaShop.Models;
using PizzaShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaShop.Data.Repositories.Contracts;
using Xunit;

namespace PizzaShop.Testing
{
    public class PizzaTests
    {
        private readonly IPizzaService _service;
        private readonly Mock<IPizzaRepo> _mockPizzaRepo;
        private readonly Mock<IIngredientRepo> _mockIngredientRepo;

        public PizzaTests()
        {
            _mockPizzaRepo = new Mock<IPizzaRepo>();
            _mockIngredientRepo = new Mock<IIngredientRepo>();
            _service = new PizzaService(_mockPizzaRepo.Object, _mockIngredientRepo.Object);
        }

        [Fact]
        public async Task Can_Map_Pizza_From_Entity()
        {
            // Arrange
            _mockPizzaRepo.Setup(x => x.GetEntityAsync(
                It.IsAny<int>()))
                .ReturnsAsync(GetMockPizzaEntity());

            // Act
            PizzaViewModel viewModel = await _service.GetPizzaWithIngredientsAsync(55);
            viewModel = (PizzaViewModel)viewModel.Convert();

            // Assert
            Assert.Equal("~/images/margarita.jpg", viewModel.Image);
            Assert.Equal("TestPizzaEntity", viewModel.Name);
            Assert.Equal(5.14M, viewModel.Price);
            Assert.Equal(3, viewModel.Ingredients.Count());
        }

        [Fact]
        public void When_Exception_Thrown_During_Save_Transaction_Should_RollBack()
        {
            // Arrange
            _mockPizzaRepo.Setup(x => x.AddEntityAsync(
                    It.IsAny<Pizza>()))
                .ReturnsAsync(1);

            // Act
            _mockIngredientRepo.Setup(x => x.PutIngredientsOnPizza(
                It.IsAny<int>(), It.IsAny<int[]>())
            ).ThrowsAsync(new Exception());
        }

        private Pizza GetMockPizzaEntity()
        {
            return new Pizza
            {
                Name = "TestPizzaEntity",
                Price = 5.14M,
                Image = "margarita.jpg",
                PizzaIngredients = new List<PizzaIngredient>
                {
                    new PizzaIngredient{ PizzaId= 1, IngredientId = 1},
                    new PizzaIngredient{ PizzaId= 1, IngredientId = 2},
                    new PizzaIngredient{ PizzaId= 1, IngredientId = 3}
                }
            };
        }

        private PizzaViewModel GetMockPizzaViewModel()
        {
            return new PizzaViewModel
            {
                Name = "TestPizzaViewModel",
                Price = 5.14M,
                Image = "~/images/margarita.jpg",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient{ IngredientId = 1},
                    new Ingredient{ IngredientId = 2},
                    new Ingredient{ IngredientId = 3}
                }
            };
        }
    }
}