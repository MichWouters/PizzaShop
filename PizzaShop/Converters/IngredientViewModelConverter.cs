using AutoMapper;
using PizzaShop.Business.Models;
using PizzaShop.ViewModels;
using System;

namespace PizzaShop.Converters
{
    public class IngredientViewModelConverter : ITypeConverter<IngredientModel, IngredientViewModel>
    {
        public IngredientViewModel Convert(IngredientModel source, IngredientViewModel destination, ResolutionContext context)
        {
            throw new NotImplementedException();
        }
    }
}