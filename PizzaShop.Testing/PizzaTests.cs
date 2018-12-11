using Moq;
using PizzaShop.Business.Models;
using PizzaShop.Business.Services;
using PizzaShop.Configuration;
using PizzaShop.Data.Entities;
using PizzaShop.Data.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            AutoMapperPresentationConfiguration.RegisterMaps();
        }

        [Fact]
        public async Task Can_Map_PizzaModel_From_PizzaEntity()
        {
            // Arrange
            _mockPizzaRepo.Setup(x => x.GetEntityAsync(
                It.IsAny<int>()))
                .ReturnsAsync(GetMockPizzaEntity());

            // Act
            PizzaModel model = await _service.GetPizzaWithIngredientsAsync(55);

            // Assert
            Assert.Equal("margarita.jpg", model.Image);
            Assert.Equal("TestPizzaEntity", model.Name);
            Assert.Equal(5.14M, model.Price);
            Assert.Equal(3, model.Ingredients.Count());
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