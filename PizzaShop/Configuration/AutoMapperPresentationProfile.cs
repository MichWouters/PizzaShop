using AutoMapper;
using PizzaShop.Business.Models;
using PizzaShop.Converters;
using PizzaShop.ViewModels;
using System.Linq;

namespace PizzaShop.Configuration
{
    public class AutoMapperPresentationProfile : Profile
    {
        public AutoMapperPresentationProfile()
        {
            CreateMap<PizzaModel, PizzaDetailViewModel>()
                .ForMember(x => x.Ingredients, y => y.MapFrom(z => z.Ingredients.Select(x => x.Name).ToArray()))
                .ForMember(x => x.Image, y => y.MapFrom(z => "../../images/" + z.Image))
                .ReverseMap();

            CreateMap<IngredientModel, IngredientViewModel>()
                .ReverseMap();

            CreateMap<CartModel, CartViewModel>()
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Pizza.Name))
                .ForMember(x => x.Price, y => y.MapFrom(z => z.Pizza.Price))
                .ReverseMap();
        }
    }
}