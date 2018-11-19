using Moq;
using PizzaShop.Data.Entities;
using PizzaShop.Data.Repositories;
using PizzaShop.Models;
using PizzaShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace PizzaShop.Testing
{
    public class PizzaTests
    {
        private IPizzaService _service;
        private Mock<IPizzaRepo> mockPizzaRepo;
        private Mock<IIngredientRepo> mockIngredientRepo;

        public PizzaTests()
        {
            mockPizzaRepo = new Mock<IPizzaRepo>();
            mockIngredientRepo = new Mock<IIngredientRepo>();
            _service = new PizzaService(mockPizzaRepo.Object, mockIngredientRepo.Object);
        }

        [Fact]
        public async Task Can_Map_Pizza_From_Entity()
        {
            // Arrange
            mockPizzaRepo.Setup(x => x.GetPizzaWithIngredientsAsync(
                It.IsAny<int>(), It.IsAny<bool>()))
                .ReturnsAsync(GetMockPizzaEntity());

            // Act
            Pizza mockPizza = await mockPizzaRepo.Object.GetPizzaWithIngredientsAsync(55);
            PizzaViewModel viewModel = _service.MapFromEntity(mockPizza);
            viewModel = (PizzaViewModel)viewModel.Convert();

            // Assert
            Assert.Equal("~/images/margherita.jpg", viewModel.Image);
            Assert.Equal(mockPizza.Name, viewModel.Name);
            Assert.Equal(mockPizza.Price, viewModel.Price);
            Assert.Equal(mockPizza.PizzaIngredients.Count, viewModel.Ingredients.Count());
        }

        private PizzaViewModel GetMockPizzaViewModel()
        {
            return new PizzaViewModel
            {
                Name = "TestPizza",
                Price = 5.14,
                Image = "margherita.jpg",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient{ IngredientId = 1},
                    new Ingredient{ IngredientId = 2},
                    new Ingredient{ IngredientId = 3}
                }
            };
        }

        private Pizza GetMockPizzaEntity()
        {
            return new Pizza
            {
                Name = "TestPizza",
                Price = 5.14,
                Image = "margherita.jpg",
                PizzaIngredients = new List<PizzaIngredient>
                {
                    new PizzaIngredient{ PizzaId= 1, IngredientId = 1},
                    new PizzaIngredient{ PizzaId= 1, IngredientId = 2},
                    new PizzaIngredient{ PizzaId= 1, IngredientId = 3}
                }
            };
        }

        [Fact]
        public void Can_Save_Pizza()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void When_Exception_Thrown_During_Save_Transaction_Should_RollBack()
        {
            throw new NotImplementedException();
        }
    }
}