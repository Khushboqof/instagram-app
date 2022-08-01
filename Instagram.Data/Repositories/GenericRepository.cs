using Instagram.Data.Contexts;
using Instagram.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Instagram.Data.Repositories
{
    public class GenericRepository<TSource> : IGenericRepository<TSource> where TSource : class
    {
        protected readonly InstagramDbContext _context;
        private readonly DbSet<TSource> _dbSet;

        public GenericRepository(InstagramDbContext dbContext) 
        {
            this._context = dbContext;
            _dbSet = dbContext.Set<TSource>();
        }

        public async Task<TSource> CreateAsync(TSource entity)
        {
            var entityCreated = await _dbSet.AddAsync(entity);

            await _context.SaveChangesAsync();

            return entityCreated.Entity;
        }
            
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IQueryable<TSource> GetAll(Expression<Func<TSource, bool>> expression = null)
            => expression is null ? _dbSet : _dbSet.Where(expression);

        public Task<TSource> GetAsync(Expression<Func<TSource, bool>> expression)
            => _dbSet.FirstAsync(expression);

        public Task SaveChanges()
            => _context.SaveChangesAsync();

        public TSource UpdateAsync(TSource entity)
        {
            var updatecontext = _dbSet.Update(entity);

            _context.SaveChanges();

            return updatecontext.Entity;
        }

        async Task<bool> IGenericRepository<TSource>.DeleteAsync(Expression<Func<TSource, bool>> expression)
        {
            var exist = await _dbSet.FirstOrDefaultAsync(expression);

            if (exist == null)
                return false;

            _dbSet.Remove(exist);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
