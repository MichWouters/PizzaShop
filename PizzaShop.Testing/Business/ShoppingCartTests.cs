using AutoMapper;
using Moq;
using PizzaShop.Business.Models;
using PizzaShop.Business.Services;
using PizzaShop.Configuration;
using PizzaShop.Data.Entities;
using PizzaShop.Data.Repositories.Contracts;
using System;
using System.Collections.Generic;
using Xunit;

namespace PizzaShop.Testing.Business
{
    public class ShoppingCartTests
    {
        private Mock<IShoppingCartRepo> _repo;
        private IShoppingCartService _service;

        public ShoppingCartTests()
        {
            // Initialize AutoMapper for Unit Tests
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperBusinessProfile>();
            });

            IMapper mapper = config.CreateMapper();

            // Initialize Service with Dependencies
            _repo = new Mock<IShoppingCartRepo>();
            _service = new ShoppingCartService(_repo.Object, mapper);
        }

        [Fact]
        public void Can_Add_Item_To_Cart()
        {
            // Arrange
            _repo.Setup(x => x.GetShoppingCartForUser(
                It.IsAny<int>()))
                .Returns(GetMockEntities);

            var mockModel = new CartModel
            {
                Pizza = new PizzaModel
                {
                    Name = "Forestiere",
                    Price = 12.25M
                },
                Quantity = 3
            };

            // Act
            _service.InitializeCart();
            int itemsAdded = _service.AddItemToCart(mockModel);
            int amountOfItemsinCart = _service.GetAmountOfItemsInCart();

            // Assert
            Assert.Equal(1, itemsAdded);
            Assert.Equal(3, amountOfItemsinCart);
        }

        [Fact]
        public void Can_Remove_Item_From_Cart()
        {
            // Arrange
            _repo.Setup(x => x.GetShoppingCartForUser(
                It.IsAny<int>()))
                .Returns(GetMockEntities);

            var mockModel = new CartModel
            {
                Pizza = new PizzaModel
                {
                    Name = "Forestiere",
                    Price = 12.25M
                },
                Quantity = 3
            };

            // Act
            _service.InitializeCart();
            int itemsAdded = _service.RemoveItemFromCart(mockModel);
            int amountOfItemsinCart = _service.GetAmountOfItemsInCart();

            // Assert
            Assert.Equal(1, itemsAdded);
            Assert.Equal(1, amountOfItemsinCart);
        }

        [Fact]
        public void Can_Clear_Cart()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Can_Match_Cart_To_User()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Calculate_Total_Correct()
        {
            throw new NotImplementedException();
        }

        private IEnumerable<Cart> GetMockEntities()
        {
            var list = new List<Cart>(){
                new Cart
                {
                    PizzaId = 2,
                    Quantity = 3
                },
                new Cart
                {
                    PizzaId = 1,
                    Quantity = 1,
                },
            };
            return list;
        }
    }
}