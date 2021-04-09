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
        public string GenerateToken(string userName)
        {
            DateTime now = DateTime.UtcNow;
            var expiry = now.AddMinutes(jwtConfig.AccessTokenExpiration);
            var claims = new[] { new Claim(ClaimTypes.Name, userName) };
            var token = new JwtSecurityToken(
                issuer: jwtConfig.Issuer,
                audience: jwtConfig.Audience,
                claims: claims,
                notBefore: now,
                expires: expiry,
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtConfig.Secret)), SecurityAlgorithms.HmacSha256Signature));
            var generatedToken = new JwtSecurityTokenHandler().WriteToken(token);

            return generatedToken;
        }
    }
}
