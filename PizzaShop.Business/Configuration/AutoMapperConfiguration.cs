using AutoMapper;
using PizzaShop.Business.Models;
using PizzaShop.Data.Entities;

namespace PizzaShop.Services
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<Pizza, PizzaViewModel>()
                .ForMember(model => model.Ingredients, x => x.MapFrom(entity => entity.PizzaIngredients))
                .ReverseMap();

            CreateMap<PizzaViewModel, Pizza>()
                .ReverseMap();

            CreateMap<Ingredient, IngredientModel>()
                .ReverseMap();
        }
    }
}