using BuberApi.Application.Common.Interfaces.Authentication;
using BuberApi.Application.Common.service;
using BuberApi.Infrastructure.Authentication;
using BuberApi.Infrastructure.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace BuberApi.Infrastructure
{
    public static class Dependencies
    {
        public static IServiceCollection AddInfrastructureDependency(this IServiceCollection services, 
        ConfigurationManager configuration)
        {
            services.Configure<JwtSetting>(configuration.GetSection(JwtSetting.JwtSettingName));
            services.AddScoped<IJwtGenerator, JwtGenerator>();
            services.AddScoped<IDateTimeProvider,DateTimeProvider>();
            return services;
        }
    }
}