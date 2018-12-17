using AutoMapper;
using PizzaShop.Business.Models;
using PizzaShop.Converters;
namespace PizzaShop.Configuration
{
    public class AutoMapperPresentationProfile : Profile
    {
        public AutoMapperPresentationProfile()
        {
            CreateMap<PizzaModel, PizzaDetailViewModel>()
                    .ConvertUsing<PizzaViewModelConverter>();

            CreateMap<IngredientModel, IngredientViewModel>()
               .ReverseMap();
        }
    }
}