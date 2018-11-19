using PizzaShop.Data.Entities;
using PizzaShop.Models;

namespace PizzaShop.Services
{
    public interface IMappableService<TEntity, TModel>
        where TEntity : Entity
        where TModel : Model
    {
        TModel MapFromEntity(TEntity entity);
        TEntity MapToEntity(TModel model);
    }
}