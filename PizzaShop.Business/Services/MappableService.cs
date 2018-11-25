using AutoMapper;
using AutoMapper.Configuration;
using PizzaShop.Business.Models;
using PizzaShop.Data.Entities;
using PizzaShop.Services;

namespace PizzaShop.Business.Services
{
    public abstract class MappableService<TEntity, TModel>
        where TEntity : Entity
        where TModel : Model
    {
        private IMapper _mapper;

        protected MappableService()
        {
            SetUpMapperConfig();
        }

        protected void SetUpMapperConfig()
        {
            var baseMappings = new MapperConfigurationExpression();
            baseMappings.AddProfile<AutoMapperConfiguration>();
            var config = new MapperConfiguration(baseMappings);

            _mapper = new Mapper(config);
        }

        protected TModel MapFromEntity(TEntity entity)
        {
            TModel model = _mapper.Map<TModel>(entity);
            return model;
        }

        protected TEntity MapToEntity(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            return entity;
        }
    }
}