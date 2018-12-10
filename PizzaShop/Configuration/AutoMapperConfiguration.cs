using AutoMapper;
using PizzaShop.Business.Models;
using PizzaShop.Converters;
using PizzaShop.Data.Entities;

namespace PizzaShop.Configuration
{
    public static class AutoMapperConfiguration
    {
        public static void RegisterMaps()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Pizza, PizzaModel>()
                    .ForMember(model => model.Ingredients, x => x.MapFrom(entity => entity.PizzaIngredients))
                    .ReverseMap();

                config.CreateMap<PizzaModel, PizzaViewModel>()
                    .ConvertUsing<PizzaViewModelConverter>();

                config.CreateMap<Ingredient, IngredientModel>()
                    .ReverseMap();
            });
        }
    }
}