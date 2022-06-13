using System.Linq.Expressions;

namespace WebApplication32.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<List<T>> GetAll(Expression<Func<T, bool>> predicate);
        Task<T> Get(int id);
        Task<T> Get(Expression<Func<T, bool>> predicate);
        Task<T> Post(T entity);
        Task<T> Put(T entity);
        Task<T> Delete(T entity);
    }
}
