using Blog.DataAccessLayer.Context;
using Blog.DataAccessLayer.Repositories.Concrate;
using Blog.DataAccessLayer.Repositories.Contract;
using Blog.DataAccessLayer.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.Extensions
{
    public static class DataLayerExtension
    {
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services,IConfiguration config)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(config.GetConnectionString("DbConnection")));
            
            services.AddScoped<IUnitOfWork,Blog.DataAccessLayer.UnitsOfWork.UnitOfWork>();
            return services;
        }
    }
}
