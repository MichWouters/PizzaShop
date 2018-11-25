using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaShop.Data.Repositories.Contracts
{
    public interface IRepository<T> where T : Entities.Entity
    {
        Task<int> AddEntityAsync(T entity);

        Task<int> UpdateEntityAsync(int id, T entity);

        Task<int> DeleteEntityAsync(T entity);

        Task<T> GetEntityAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();
    }
}