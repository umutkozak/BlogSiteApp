using Blog.Core.Entities;
using Blog.DataAccessLayer.Context;
using Blog.DataAccessLayer.Repositories.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.Repositories.Concrate
{
    public class Repository<T> : IRepository<T> where T : class,IBaseEntity,new()    
    {
        private readonly AppDbContext appDb;
        private DbSet<T> Table { get => appDb.Set<T>(); }
        public Repository(AppDbContext appDb)
        {
            this.appDb = appDb;
        }
        public async Task AddAsync(T Entity)
        {
            await Table.AddAsync(Entity);
        
        }

        public async Task<bool> AnyAsycn(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
          return await Table.AnyAsync(predicate);
        }

        public async Task<int> CountAsycn(System.Linq.Expressions.Expression<Func<T, bool>> predicate = null)
        {
            return await Table.CountAsync(predicate);
        }

        public async Task DeleteAsync(T Entity)
        {
            await Task.Run(() => Table.Remove(Entity));
            
        }

        public async Task<List<T>> GetAllAsync(System.Linq.Expressions.Expression<Func<T, bool>> predicate = null, params System.Linq.Expressions.Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Table;
            if (predicate!=null)
            {
                query=query.Where(predicate);
            }
            if (includeProperties.Any())
            {
                foreach (var item in includeProperties)
                {
                    query=query.Include(item);
                }
            }
            return await query.ToListAsync();
        }

        public async Task<T> GetAsycn(System.Linq.Expressions.Expression<Func<T, bool>> predicate = null, params System.Linq.Expressions.Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Table;
            query=query.Where(predicate);
           
            if (includeProperties.Any())
            {
                foreach (var item in includeProperties)
                {
                    query=query.Include(item);
                }
            }
            return await query.SingleAsync();
        }

        public async Task<T> GetByGuidAsycn(Guid id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<T> UpdateAsync(T Entity)
        {
            await Task.Run(()=>Table.Update(Entity));
            return Entity;
        }
    }
}
