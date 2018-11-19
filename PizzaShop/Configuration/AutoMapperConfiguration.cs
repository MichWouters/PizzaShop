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
                .ForMember(model => model.Image, entity => entity.ResolveUsing(x => x.Image + "foo"))
                .ReverseMap();

            CreateMap<PizzaViewModel, Pizza>()
                .ReverseMap();
        }
    }
}