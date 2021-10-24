using Microsoft.Extensions.DependencyInjection;
using StuffFinder.Application.Initializers;
using StuffFinder.Application.Services;
using StuffFinder.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuffFinder.Application
{
    /// <summary>
    /// Injects the application dependencies in the API scope
    /// </summary>
    public static class ApplicationModuleDependency
    {
        /// <summary>
        /// Export the application modules available
        /// </summary>
        /// <param name="services">An instance of <see cref="IServiceCollection"/></param>
        public static void AddApplicationModule(this IServiceCollection services)
        {
            services.AddScoped<IStuffService, StuffService>();
            services.AddScoped<IStuffContainerService, StuffContainerService>();

            services.AddTransient<DataBaseInitializer>();
        }
    }
}
