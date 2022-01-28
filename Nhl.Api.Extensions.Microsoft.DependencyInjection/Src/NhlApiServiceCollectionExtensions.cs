using Microsoft.Extensions.DependencyInjection;

namespace Nhl.Api.Extensions.Microsoft.DependencyInjection
{
    /// <summary>
    /// The extensions for the Nhl.Api for Microsoft Dependency Injection
    /// </summary>
    public static class NhlApiServiceCollectionExtensions
    {
        /// <summary>
        /// Register's the Nhl.Api to the <see cref="IServiceCollection"/> for usage within the Microsoft dependency injection library
        /// </summary>
        /// <param name="services">The collection of services from the <see cref="IServiceCollection"/></param>
        /// <param name="serviceLifetime">The type of service lifetime the Nhl.Api will be injected into the <see cref="IServiceCollection"/> </param>
        /// <returns>Returns an updated <see cref="IServiceCollection"/> with the Nhl.Api included</returns>
        public static IServiceCollection AddNhlApi(this IServiceCollection services, ServiceLifetime serviceLifetime = ServiceLifetime.Singleton)
        {

            switch (serviceLifetime)
            {
                case ServiceLifetime.Singleton:
                    services.AddSingleton<INhlApi, NhlApi>();
                    services.AddSingleton<INhlPlayerApi, NhlPlayerApi>();
                    services.AddSingleton<INhlLeagueApi, NhlLeagueApi>();
                    services.AddSingleton<INhlGameApi, NhlGameApi>();
                    services.AddSingleton<INhlStatisticsApi, NhlStatisticsApi>();
                    break;

                case ServiceLifetime.Scoped:
                    services.AddScoped<INhlApi, NhlApi>();
                    services.AddScoped<INhlPlayerApi, NhlPlayerApi>();
                    services.AddScoped<INhlLeagueApi, NhlLeagueApi>();
                    services.AddScoped<INhlGameApi, NhlGameApi>();
                    services.AddScoped<INhlStatisticsApi, NhlStatisticsApi>();
                    break;

                case ServiceLifetime.Transient:
                    services.AddTransient<INhlApi, NhlApi>();
                    services.AddTransient<INhlPlayerApi, NhlPlayerApi>();
                    services.AddTransient<INhlLeagueApi, NhlLeagueApi>();
                    services.AddTransient<INhlGameApi, NhlGameApi>();
                    services.AddTransient<INhlStatisticsApi, NhlStatisticsApi>();
                    break;
            }

            return services;
        }
    }
}
