using System.Collections.Generic;

namespace PizzaShop.Data.Repositories
{
    internal interface IRepository<T> where T : Entities.Entity
    {
        int AddEntity(T entity);

        int UpdateEntity(int id, T entity);

        int DeleteEntity(int id);

        T GetEntity(int id);

        IEnumerable<T> GetAll();
    }
}