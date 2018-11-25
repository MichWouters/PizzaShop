using AutoMapper;
using AutoMapper.Configuration;
using PizzaShop.Business.Models;
using PizzaShop.Data.Entities;
using PizzaShop.Services;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

        protected IEnumerable<TModel> MapFromEntities(IEnumerable<TEntity> entities)
        {
            return entities.Select(entity => _mapper.Map<TModel>(entity)).ToList();
        }

        protected IEnumerable<TEntity> MapToEntities(IEnumerable<TModel> models)
        {
            return models.Select(model => _mapper.Map<TEntity>(model)).ToList();
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