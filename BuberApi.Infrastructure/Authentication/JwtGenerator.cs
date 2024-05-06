using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BuberApi.Application.Common.Interfaces.Authentication;
using Microsoft.IdentityModel.Tokens;

namespace BuberApi.Infrastructure.Authentication
{
    public class JwtGenerator : IJwtGenerator
    {
        public string GenerateJwt(string userId, string firstName, string lastName)
        {
            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes("my_security_key_to_encrypt_decrypt")),
                    SecurityAlgorithms.HmacSha256
            );

            var claims = new List<Claim>()
            {
                new(JwtRegisteredClaimNames.Sub,userId),
                new(JwtRegisteredClaimNames.GivenName,firstName),
                new(JwtRegisteredClaimNames.FamilyName,lastName),
                new(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };

            var securityToken = new JwtSecurityToken(
                issuer : "my_testing_Jwt",
                expires : DateTime.Now.AddMinutes(10),
                claims : claims,
                signingCredentials : signingCredentials
            );

            return new JwtSecurityTokenHandler().WriteToken(securityToken);
            
        }
    }
}