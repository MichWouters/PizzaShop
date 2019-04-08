using AutoMapper;
using PizzaShop.Business.Models;
using PizzaShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaShop.Business.Converters
{
    public class PizzaEntityToModelConverter : ITypeConverter<Pizza, PizzaModel>
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
            destination.Total = CalculateTotal(destination.Price, destination.VAT);

            IEnumerable<Ingredient> entities = source.PizzaIngredients.Select(x => x.Ingredient).ToList();

            // TODO: This does not belong here
            IEnumerable<IngredientModel> models = Mapper.Map<IEnumerable<IngredientModel>>(entities);
            destination.Ingredients = models;

            return destination;
        }

        private decimal CalculateVat(decimal price, int precision = 2)
        {
            return Math.Round(price * 0.06M, precision);
        }

        private decimal CalculateTotal(decimal price, decimal vat, int precision = 2)
        {
            return Math.Round(price + vat, precision);
        }
    }
}