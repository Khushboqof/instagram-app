using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Instagram.Data.IRepositories
{
    public interface IGenericRepository<TSource> : IDisposable
        where TSource : class
    {
        Task<TSource> CreateAsync(TSource entity);
        Task<TSource> UpdateAsync(TSource entity);
        Task<TSource> GetAsync(Expression<Func<TSource, bool>> expression);
        Task<bool> DeleteAsync(Expression<Func<TSource, bool>> expression);
        IQueryable<TSource> GetAll(Expression<Func<TSource, bool>> expression = null);
        Task SaveChanges();
    }
}
