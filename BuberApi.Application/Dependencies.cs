using BuberApi.Application.services.Authentication;
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