using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.Repositories.Contract
{
    public interface IRepository<T> where T : class,IBaseEntity, new()
    {
        Task AddAsync(T Entity);
        Task<T> UpdateAsync(T Entity);
        Task DeleteAsync(T Entity);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetAsycn(Expression<Func<T,bool>>predicate=null,params Expression<Func<T, object>>[]includeProperties);
        Task<T> GetByGuidAsycn(Guid id);
        Task<bool> AnyAsycn(Expression<Func<T,bool>>predicate);
        Task<int> CountAsycn(Expression<Func<T,bool>>predicate=null);
    }
}
