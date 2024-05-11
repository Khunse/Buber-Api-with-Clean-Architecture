using BuberApi.Application.Common.Interfaces.Authentication;
using BuberApi.Application.services.Persistence;
using BuberApi.Domain.Entities;

namespace BuberApi.Application.services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtGenerator _jwtGenerator;
        private readonly IUserRepository _userRepository;
        public AuthenticationService(IJwtGenerator jwtGenerator,IUserRepository userRepository)
        {
            _jwtGenerator = jwtGenerator;
            _userRepository = userRepository;
        }

        public AuthenticationResult Login(string email, string password)
        {
            if(_userRepository.GetUserByEmail(email) is not User user)
            {
                throw new Exception("User not exist!");
            }

            if(!user.Password.Equals(password))
            {
                throw new Exception("user or password is incorrect!");
            }

            var newToken = _jwtGenerator.GenerateJwt(Guid.NewGuid().ToString(),user.FirstName,user.LastName);

            return new AuthenticationResult(
                Guid.NewGuid(),
                "FName",
                "LName",
                "Email",
                newToken
                );
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            if( _userRepository.GetUserByEmail(email) is not null)
            {
                throw new Exception("user already exist!");
            }

            var newUser = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password
            };

            _userRepository.AddUser(newUser);

                return new AuthenticationResult(Guid.NewGuid(),
                    firstName,
                    lastName,
                    email,
                    _jwtGenerator.GenerateJwt(Guid.NewGuid().ToString(),firstName,lastName)
                    );
        }
    }
}