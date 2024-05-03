namespace BuberApi.Application.services.Authentication
{
    public record AuthenticationResult(
        Guid Id,
        string FirstName,
        string LastName,
        string Email,
        string Token
    );
}