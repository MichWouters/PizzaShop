using AutoMapper;
using PizzaShop.Business.Converters;
using PizzaShop.Business.Models;
using PizzaShop.Data.Entities;

namespace PizzaShop.Configuration
{
    public class AutoMapperModelProfile : Profile
    {
        public AutoMapperModelProfile()
        {
            CreateMap<Pizza, PizzaModel>()
                    .ConvertUsing<PizzaModelConverter>();

            CreateMap<Ingredient, IngredientModel>()
                   .ForMember(x => x.IngredientId, y => y.MapFrom(z => z.IngredientId))
                   .ReverseMap();
        }
    }
}