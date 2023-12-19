using Hospital.Models.Common;
using System.Linq.Expressions;

namespace Hospital.API.Repositories.Abstract
{
    public interface ISQLRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindAll(Expression<Func<T, bool>> method);
        Task<T> GetAsync(Guid id);
        Task<T> FindAsync(Expression<Func<T, bool>> method);
        Task<T> AddAsync(T entity);
        Task<IEnumerable<T>> AddRangeAsync(List<T> entity);
        Task<Guid> RemoveAsync(Guid id);
        Guid Remove(T entity);
        IEnumerable<Guid> RemoveRange(List<T> entities);
        T Update(T entity);
        Task<int> SaveAsync();
    }
}
