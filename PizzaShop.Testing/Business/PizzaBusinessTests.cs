﻿using AutoMapper;
using Moq;
using PizzaShop.Business.Models;
using PizzaShop.Business.Services;
using PizzaShop.Configuration;
using PizzaShop.Data.Entities;
using PizzaShop.Data.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace PizzaShop.Testing.Business
{
    public class PizzaBusinessTests
    {
        private readonly IPizzaService _service;
        private readonly Mock<IPizzaRepo> _mockPizzaRepo;
        private readonly Mock<IIngredientRepo> _mockIngredientRepo;

        public PizzaBusinessTests()
        {
            // Initialize AutoMapper for Unit Tests
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperBusinessProfile>();
            });

            IMapper mapper = config.CreateMapper();

            // Initialize Service with Dependencies
            _mockPizzaRepo = new Mock<IPizzaRepo>();
            _mockIngredientRepo = new Mock<IIngredientRepo>();
            _service = new PizzaService(_mockPizzaRepo.Object, _mockIngredientRepo.Object, mapper);
        }

        [Fact]
        public async Task Can_Map_PizzaModel_From_PizzaEntity()
        {
            // Arrange
            _mockPizzaRepo.Setup(x => x.GetPizzaWithIngredientsAsync(
                It.IsAny<int?>(), It.IsAny<bool>()))
                .ReturnsAsync(GetMockPizzaEntity);

            // Act
            PizzaModel model = await _service.GetPizzaWithIngredientsAsync(55);

            // Assert
            Assert.Equal("margarita.jpg", model.Image);
            Assert.Equal("TestPizzaEntity", model.Name);
            Assert.Equal(5.14M, model.Price);
            Assert.Equal(3, model.Ingredients.Count());
        }

        [Fact]
        public async Task Can_Calculate_ValuesCorrectly()
        {
            // Arrange
            _mockPizzaRepo.Setup(x => x.GetPizzaWithIngredientsAsync(It.IsAny<int?>(), It.IsAny<bool>()))
                .ReturnsAsync(GetMockPizzaEntity);

            // Act
            PizzaModel model = await _service.GetPizzaWithIngredientsAsync(55);

            // Assert
            Assert.Equal(0.31M, model.VAT);
            Assert.Equal(5.45M, model.Total);
        }

        [Fact]
        public async Task WhenNoInput_GetPizzaWithIngredientsAsync_ThrowsArgumentNullException()
        {
            var code = _service.GetPizzaWithIngredientsAsync(0);
            await Assert.ThrowsAsync<ArgumentNullException>(async () => await code);
        }

        [Fact]
        public void When_Exception_Thrown_During_Save_Transaction_Should_RollBack()
        {
            // Arrange
            _mockPizzaRepo.Setup(x => x.AddEntityAsync(
                    It.IsAny<Pizza>()))
                .ReturnsAsync(1);

            _mockIngredientRepo.Setup(x => x.PutIngredientsOnPizza(
                It.IsAny<int>(), It.IsAny<int[]>())
            ).ThrowsAsync(new Exception());

            // Act
            throw new NotImplementedException();

            // Assert
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
    }
}