using AutoMapper;
using PizzaShop.Business.Models;
using PizzaShop.Data.Entities;
using PizzaShop.Data.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaShop.Business.Converters
{
    public class PizzaModelConverter : ITypeConverter<Pizza, PizzaModel>
    {
        public PizzaModel Convert(Pizza source, PizzaModel destination, ResolutionContext context)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (destination == null)
                throw new ArgumentNullException(nameof(destination));

            destination.Description = source.Description;
            destination.Image = source.Image;
            destination.IsAvailable = true; // TODO: Make dynamic
            destination.Name = source.Name;
            destination.PizzaId = source.PizzaId;
            destination.Price = source.Price;
            destination.VAT = CalculateVat(source.Price);
            destination.Ingredients = source.PizzaIngredients.Select(x => x.Ingredient).ToList();

            return destination;
        }

        //private IEnumerable<Ingredient> MapIngredientToPizzaAsync(PizzaModel destination, IEnumerable<PizzaIngredient> PizzaIngredients)
        //{
        //    if (destination == null)
        //        throw new ArgumentNullException(nameof(destination));

        //    var ingredientList = new List<Ingredient>();

        //    foreach (PizzaIngredient pizzaIngredient in PizzaIngredients)
        //    {
        //        if (pizzaIngredient.Ingredient == null)
        //        {
        //            var ingredient = _ingredientRepo.GetEntityAsync(pizzaIngredient.IngredientId).Result;
        //            ingredientList.Add(ingredient);
        //        }
        //        else
        //        {
        //            ingredientList.Add(pizzaIngredient.Ingredient);
        //        }
        //    }

        //    return ingredientList;
        //}

        private decimal CalculateVat(decimal price, int precision = 2)
        {
            return Math.Round((price * 0.06M), precision);
        }
    }
}