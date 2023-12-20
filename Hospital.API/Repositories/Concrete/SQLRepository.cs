using Hospital.API.Repositories.Abstract;
using Hospital.Models.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace Hospital.API.Repositories.Concrete
{
    public class SQLRepository<T> : ISQLRepository<T> where T : BaseEntity
    {
        private readonly HospitalDbContext _context;

        public SQLRepository(HospitalDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
        {
            return Table;
        }
        public IQueryable<T> AsNoTracking()
        {
            return Table.AsNoTracking();
        }
        public IQueryable<T> FindAll(Expression<Func<T, bool>> method)
        {
            return Table.Where(method);
        }

        public async Task<T> GetAsync(Guid id)
        {
            return await Table.FindAsync(id);
        }
        public async Task<T> FindAsync(Expression<Func<T, bool>> method)
        {
            return await Table.FirstOrDefaultAsync(method);
        }
        public async Task<T> AddAsync(T entity)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(entity);
            return entityEntry.Entity;
        }

        public async Task<IEnumerable<T>> AddRangeAsync(List<T> entities)
        {
            await Table.AddRangeAsync(entities);
            return entities;
        }
        public async Task<Guid> RemoveAsync(Guid id)
        {
            T entity = await Table.FindAsync(id);
            return Remove(entity);
        }
        public Guid Remove(T entity)
        {
            EntityEntry<T> entityEntry = Table.Remove(entity);
            return entityEntry.Entity.Id;
        }
        public IEnumerable<Guid> RemoveRange(List<T> entities)
        {
            Table.RemoveRange(entities);
            return entities.Select(e => e.Id);
        }

        public T Update(T entity)
        {
            EntityEntry<T> entityEntry = Table.Update(entity);
            return entityEntry.Entity;
        }
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

    }
}
