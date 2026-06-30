
using System.Linq.Expressions;
using ECommerceOrder.Core.Entities;

namespace ECommerceOrder.Core.Repositories;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<T?> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
    IQueryable<T> Where(Expression<Func<T,bool>> expression);
    Task AddAsync(T entity);
    void Update(T entity);
    void remove(T entity);
}