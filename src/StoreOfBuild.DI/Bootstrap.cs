using System;
using Microsoft.Extensions.DependencyInjection;
using StoreOfBuild.Data;
using Microsoft.EntityFrameworkCore;

namespace StoreOfBuild.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string connection)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connection));

        }

    }
}
