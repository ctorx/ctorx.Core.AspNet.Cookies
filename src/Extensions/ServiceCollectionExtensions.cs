using Microsoft.Extensions.DependencyInjection;

namespace ctorx.Core.AspNet.Cookies.Extensions
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds Cookie Management to the application
        /// </summary>
        public static IServiceCollection AddCookieManagement(this IServiceCollection services)
        {
            services.AddScoped<CookieManager>();
            return services;
        }
    }
}