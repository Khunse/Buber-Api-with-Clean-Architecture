using BuberApi.Application.Common.Interfaces.Authentication;
using BuberApi.Infrastructure.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace BuberApi.Infrastructure
{
    public static class Dependencies
    {
        public static IServiceCollection AddInfrastructureDependency(this IServiceCollection services)
        {
            services.AddScoped<IJwtGenerator, JwtGenerator>();
            return services;
        }
    }
}