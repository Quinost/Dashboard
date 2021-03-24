using Dashboard.Shared;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Dashboard.Server.Authentication.JWT
{
    public class JwtTokenGenerator
    {
        private readonly JwtConfig jwtConfig;
        public JwtTokenGenerator(JwtConfig _jwtConfig)
        {
            jwtConfig = _jwtConfig;
        }
        public TokenModel GenerateToken(string userName, DateTime now)
        {
            var expiry = now.AddMinutes(jwtConfig.AccessTokenExpiration);
            var claims = new[] { new Claim(ClaimTypes.Name, userName) };
            var token = new JwtSecurityToken(
                jwtConfig.Issuer,
                jwtConfig.Audience,
                claims,
                expires: expiry,
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtConfig.Secret)), SecurityAlgorithms.HmacSha256Signature));
            var generatedToken = new JwtSecurityTokenHandler().WriteToken(token);

            return new TokenModel { Token = generatedToken, Expiration = expiry };
        }
    }
}
