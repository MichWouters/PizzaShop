using System.Collections.Generic;

namespace PizzaShop.Data.Repositories
{
    public interface IRepository<T> where T : Entities.Entity
    {
        int AddEntity(T entity);

        int UpdateEntity(int id, T entity);

        int DeleteEntity(T entity);

        T GetEntity(int id);

        IEnumerable<T> GetAll();
    }
}