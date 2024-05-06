using BuberApi.Application.Common.service;

namespace BuberApi.Infrastructure.Service
{
    public class DateTimeProvider : IDateTimeProvider
    {
         public DateTime GetDateTime => DateTime.UtcNow;
    }
}