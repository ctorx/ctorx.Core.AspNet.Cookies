using System;
using Microsoft.Extensions.DependencyInjection;

namespace ctorx.Core.Mvc.Cookies.Extensions
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds Cookie Management to the application
        /// </summary>
        /// <param name="services">IServiceCollection for the application</param>
        /// <returns>ServiceCollectin</returns>
        public static IServiceCollection AddCookieManagement(this IServiceCollection services)
        {
            services.AddScoped<ICookieManager, DefaultCookieManager>();
            return services;
        }
    }
}