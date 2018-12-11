using AutoMapper;
using PizzaShop.Business.Models;
using PizzaShop.Converters;

namespace PizzaShop.Configuration
{
    public static class AutoMapperPresentationConfiguration
    {
        public static void RegisterMaps()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<PizzaModel, PizzaDetailViewModel>()
                    .ConvertUsing<PizzaViewModelConverter>();
            });
        }
    }
}