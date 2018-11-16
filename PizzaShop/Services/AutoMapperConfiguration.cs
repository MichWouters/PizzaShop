using AutoMapper;
using PizzaShop.Data.Entities;
using PizzaShop.Models;

namespace PizzaShop.Services
{
    public class AutoMapperConfiguration: Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<Pizza, PizzaViewModel>()
                .ReverseMap();

            CreateMap<PizzaViewModel, Pizza >()
                .ReverseMap();
        }
    }
}
