using Assignment.Model;
using Assignment.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Repository.Service
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected ApplicationDBContext _dbContext;
        internal DbSet<T> dbSet;
        public GenericRepository(ApplicationDBContext dbContext)
        {
            this._dbContext = dbContext;
            this.dbSet = this._dbContext.Set<T>();
        }

        public virtual Task<List<T>> GetAllEntity()
        {
            return this.dbSet.ToListAsync();
        }

        public virtual Task<T> GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> AddEntity(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> UpdateEntity(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }
    }
}
