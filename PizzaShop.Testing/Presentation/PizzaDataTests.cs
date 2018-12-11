using Moq;
using PizzaShop.Data.Entities;
using PizzaShop.Data.Repositories.Contracts;
using System;
using Xunit;

namespace PizzaShop.Testing.Presentation
{
    public class PizzaDataTests
    {
        private readonly Mock<IPizzaRepo> _mockPizzaRepo;
        private readonly Mock<IIngredientRepo> _mockIngredientRepo;

        public PizzaDataTests()
        {
            _mockPizzaRepo = new Mock<IPizzaRepo>();
            _mockIngredientRepo = new Mock<IIngredientRepo>();
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

            // Assert
            throw new NotImplementedException();
        }
    }
}
