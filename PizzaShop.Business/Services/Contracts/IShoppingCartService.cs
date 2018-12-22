﻿using System.Collections.ObjectModel;
using PizzaShop.Business.Models;

namespace PizzaShop.Business.Services
{
    public interface IShoppingCartService
    {
        ObservableCollection<CartModel> ShoppingCart { get; set; }
    }
}