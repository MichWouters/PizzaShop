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
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Pizza, PizzaModel>()
                    .ReverseMap();

                cfg.CreateMap<PizzaModel, PizzaDetailViewModel>()
                    .ConvertUsing<PizzaViewModelConverter>();

                cfg.CreateMap<Ingredient, IngredientModel>()
                    .ForMember(x => x.Id, y => y.MapFrom(z => z.IngredientId))
                    .ForMember(x => x.IsVegetarian, y => y.MapFrom(z => z.IsVegetarian))
                    .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                    .ForMember(x => x.Type, y => y.MapFrom(z => z.Type))
                    .ReverseMap();
            });
        }
    }
}