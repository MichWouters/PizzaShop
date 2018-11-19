using AutoMapper;
using PizzaShop.Data.Entities;
using PizzaShop.Models;

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
        }
    }
}