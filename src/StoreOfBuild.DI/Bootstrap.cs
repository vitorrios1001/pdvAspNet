using System;
using Microsoft.Extensions.DependencyInjection;
using StoreOfBuild.Data;
using Microsoft.EntityFrameworkCore;
using StoreOfBuild.Domain;
using StoreOfBuild.Domain.Products;

namespace StoreOfBuild.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string connection)
        {
            services.AddDbContext<ApplicationDbContext>(optionsBuilder =>
                optionsBuilder.UseMySql(connection));
            services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));
            services.AddSingleton(typeof(CategoryStorer));
        }

    }
}
