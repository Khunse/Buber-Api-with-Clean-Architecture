namespace BuberApi.Application.Common.Interfaces.Authentication
{
    public interface IJwtGenerator
    {
        string GenerateJwt(string userId,string firstName,string lastName);
    }
}