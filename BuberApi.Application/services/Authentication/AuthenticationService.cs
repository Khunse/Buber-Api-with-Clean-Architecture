namespace BuberApi.Application.services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthenticationResult Login(string email, string password)
        {
            return new AuthenticationResult(
                Guid.NewGuid(),
                "FName",
                "LName",
                "Email",
                "Token"
                );
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
                return new AuthenticationResult(Guid.NewGuid(),
                    firstName,
                    lastName,
                    email,
                    "Token");
        }
    }
}