using Microsoft.Extensions.DependencyInjection;
using StuffFinder.Domain.Repositories;
using StuffFinder.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuffFinder.Infrastructure
{
    /// <summary>
    /// Injects the database dependencies in the API scope
    /// </summary>
    public static class DataBaseInMemoryModuleDependency
    {
        /// <summary>
        /// Export the database modules available
        /// </summary>
        /// <param name="services">An instance of <see cref="IServiceCollection"/></param>
        public static void AddDataBaseInMemoryModule(this IServiceCollection services)
        {
            services.AddScoped<IStuffRepository, StuffRepository>();
            services.AddScoped<IStuffContainerRepository, StuffContainerRepository>();
        }
    }
}
