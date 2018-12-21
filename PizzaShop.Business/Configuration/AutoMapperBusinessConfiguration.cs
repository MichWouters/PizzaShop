﻿using AutoMapper;
using PizzaShop.Business.Converters;
using PizzaShop.Business.Models;
using PizzaShop.Data.Entities;

namespace PizzaShop.Configuration
{
    public class AutoMapperBusinessProfile : Profile
    {
        public AutoMapperBusinessProfile()
        {
            CreateMap<Pizza, PizzaModel>()
                    .ConvertUsing<PizzaModelConverter>();

            CreateMap<Ingredient, IngredientModel>()
                   .ForMember(x => x.Id, y => y.MapFrom(z => z.IngredientId))
                   .ReverseMap();
        }
    }
}