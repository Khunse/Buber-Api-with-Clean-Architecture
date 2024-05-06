using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BuberApi.Application.Common.Interfaces.Authentication;
using BuberApi.Application.Common.service;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace BuberApi.Infrastructure.Authentication
{
    public class JwtGenerator : IJwtGenerator
    {
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly JwtSetting _jwtSetting;
        public JwtGenerator(IDateTimeProvider dateTimeProvider,IOptions<JwtSetting> options)
        {
            _dateTimeProvider = dateTimeProvider;
            _jwtSetting = options.Value;
        }

        public string GenerateJwt(string userId, string firstName, string lastName)
        {
            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(_jwtSetting.Secret)),
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
                issuer : _jwtSetting.Issuer,
                audience : _jwtSetting.Audience,
                expires : _dateTimeProvider.GetDateTime.AddMinutes(_jwtSetting.ExpireTime),
                claims : claims,
                signingCredentials : signingCredentials
            );

            return new JwtSecurityTokenHandler().WriteToken(securityToken);
            
        }
    }
}