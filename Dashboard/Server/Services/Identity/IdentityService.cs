using Dashboard.Infrastructure.Entity;
using Dashboard.Server.Models;
using Dashboard.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Server.Services.Identity
{
    public class IdentityService
    {
        private readonly JwtConfig jwtConfig;
        private readonly UserManager<UserEntity> userManager;

        public IdentityService(JwtConfig _jwtConfig, UserManager<UserEntity> _userManager)
        {
            jwtConfig = _jwtConfig;
            userManager = _userManager;
        }

        public async Task<Result<TokenResult>> Login(string userName, string password)
        {
            var user = await userManager.FindByNameAsync(userName);
            if (user is null)
                return Result<TokenResult>.Failed("User not found");

            if (!user.IsActive)
                return Result<TokenResult>.Failed("User inactive");

            if (!await userManager.CheckPasswordAsync(user, password))
                return Result<TokenResult>.Failed("Wrong login or password");

            var retVal = await GenerateTokens(user);
            return Result<TokenResult>.Success(retVal);
        }

        public async Task Logout(string userName)
        {
            var user = await userManager.FindByNameAsync(userName);
            user.RefreshToken = null;
            user.RefreshTokenExpiry = null;
            await userManager.UpdateAsync(user);
        }

        public async Task<Result<TokenResult>> RefreshToken(RefreshTokenRequest request)
        {
            var (principal, jwtToken) = DecodeJwtToken(request.AccessToken);
            if (jwtToken == null || !jwtToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256Signature))
                return Result<TokenResult>.Failed("Invalid token");

            var userName = principal.Identity?.Name;
            var user = await userManager.FindByNameAsync(userName);
            if(user is null)
                return Result<TokenResult>.Failed("Invalid token");

            if(user.RefreshToken != request.RefreshToken || user.RefreshTokenExpiry < DateTime.Now)
                return Result<TokenResult>.Failed("Invalid token");

            var retVal = await GenerateTokens(user);
            return Result<TokenResult>.Success(retVal);
        }


        private async Task<TokenResult> GenerateTokens(UserEntity user)
        {
            user.RefreshToken = GenerateRefreshToken();
            user.RefreshTokenExpiry = DateTime.UtcNow.AddMinutes(jwtConfig.RefreshTokenExpiration);
            await userManager.UpdateAsync(user);
            var token = GenerateAccessToken(user.Username);

            return new TokenResult { AccessToken = token, RefreshToken = user.RefreshToken, RefreshTokenExpiry = user.RefreshTokenExpiry.Value };
        }


        private string GenerateAccessToken(string userName)
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

        private string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        private (ClaimsPrincipal, JwtSecurityToken) DecodeJwtToken(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                throw new SecurityTokenException("Invalid token");
            }
            var principal = new JwtSecurityTokenHandler()
                .ValidateToken(token,
                    new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateIssuerSigningKey = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = jwtConfig.Issuer,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtConfig.Secret)),
                        ValidAudience = jwtConfig.Audience,
                        ClockSkew = TimeSpan.Zero
                    },
                    out var validatedToken);
            return (principal, validatedToken as JwtSecurityToken);
        }
    }
}
