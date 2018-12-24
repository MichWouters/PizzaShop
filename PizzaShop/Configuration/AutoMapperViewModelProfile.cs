using AutoMapper;
using PizzaShop.Business.Models;
using PizzaShop.Converters;
using PizzaShop.ViewModels;

namespace PizzaShop.Configuration
{
    public class AutoMapperViewModelProfile : Profile
    {
        public AutoMapperViewModelProfile()
        {
            CreateMap<PizzaModel, PizzaDetailViewModel>()
                    .ConvertUsing<PizzaViewModelConverter>();

            CreateMap<IngredientModel, IngredientViewModel>()
               .ConvertUsing<IngredientViewModelConverter>();

            CreateMap<CartModel, CartViewModel>()
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Pizza.Name))
                .ForMember(x => x.Price, y => y.MapFrom(z => z.Pizza.Price))
                .ReverseMap();
        }
    }
}