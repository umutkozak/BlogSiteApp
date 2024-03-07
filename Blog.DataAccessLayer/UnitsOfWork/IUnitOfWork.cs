using Blog.Core.Entities;
using Blog.DataAccessLayer.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.UnitOfWork
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class,IBaseEntity, new();
        Task<int> SaveAsycn();
        public int Save();
    }
}
