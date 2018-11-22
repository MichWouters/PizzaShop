using AutoMapper;
using AutoMapper.Configuration;
using PizzaShop.Data.Entities;
using PizzaShop.Models;

namespace PizzaShop.Services
{
    public abstract class MappableService<TEntity, TModel>
        where TEntity : Entity
        where TModel : Model
    {
        private IMapper mapper;

        public MappableService()
        {
            SetUpMapperConfig();
        }

        protected void SetUpMapperConfig()
        {
            var baseMappings = new MapperConfigurationExpression();
            baseMappings.AddProfile<AutoMapperConfiguration>();
            var config = new MapperConfiguration(baseMappings);

            mapper = new Mapper(config);
        }

        protected TModel MapFromEntity(TEntity entity)
        {
            TModel model = mapper.Map<TModel>(entity);
            return model;
        }

        protected TEntity MapToEntity(TModel model)
        {
            TEntity entity = mapper.Map<TEntity>(model);
            return entity;
        }
    }
}