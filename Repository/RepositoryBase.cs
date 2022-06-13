using Microsoft.EntityFrameworkCore;
using WebApplication32.Models;

namespace WebApplication32.Repository
{
    public abstract class RepositoryBase<T> : IDisposable where T : class
    {
        protected readonly internal TestDbContext _dbContext;
        protected readonly internal DbSet<T> _dbSet;

        protected RepositoryBase(TestDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }
    }
}
