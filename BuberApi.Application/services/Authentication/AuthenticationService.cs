using BuberApi.Application.Common.Interfaces.Authentication;

namespace BuberApi.Application.services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtGenerator _jwtGenerator;
        public AuthenticationService(IJwtGenerator jwtGenerator)
        {
            _jwtGenerator = jwtGenerator;
        }

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
                    _jwtGenerator.GenerateJwt(Guid.NewGuid().ToString(),firstName,lastName)
                    );
        }
    }
}