using Moq;
using PizzaShop.Data.Entities;
using PizzaShop.Data.Repositories;
using PizzaShop.Models;
using PizzaShop.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace PizzaShop.Testing
{
    public class PizzaTests
    {
        private IPizzaService _service;

        public PizzaTests()
        {
            var mockPizzaRepo = new Mock<IPizzaRepo>();
            var mockIngredientRepo = new Mock<IIngredientRepo>();
            _service = new PizzaService(mockPizzaRepo.Object, mockIngredientRepo.Object);
        }

        [Fact]
        public void Can_Map_Pizza_From_Entity()
        {
            // Arrange

            Pizza mockPizza = GetMockPizzaEntity();
            var viewModel = _service.MapFromEntity(mockPizza);
            viewModel = (PizzaViewModel)viewModel.Convert();
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
                    new PizzaIngredient{ IngredientId = 1},
                    new PizzaIngredient{ IngredientId = 2},
                    new PizzaIngredient{ IngredientId = 3}
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