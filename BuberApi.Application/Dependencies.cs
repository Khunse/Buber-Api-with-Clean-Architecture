using BuberApi.Application.services.Authentication;
using BuberApi.Application.services.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace BuberApi.Application
{
    public static class Dependencies
    {
        public static IServiceCollection AddApplicationDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService,AuthenticationService>();
            return services;
        }

    }
}