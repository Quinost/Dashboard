using Dashboard.Infrastructure.Entity;
using Dashboard.Server.Services.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Dashboard.Server.Extensions;
public static class JwtBearerBuilderExtension
{
    public static void AddIdentityWithStore(this IServiceCollection services)
    {
        services.AddIdentityCore<UserEntity>()
            .AddUserStore<Services.Identity.UserStore>();
    }

    public static void AddJwtBearerToken(this IServiceCollection services, JwtConfig jwtConfig)
    {
        services.AddAuthentication(v =>
        {
            v.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            v.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(v =>
        {
            v.RequireHttpsMetadata = true;
            v.SaveToken = true;
            v.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateIssuerSigningKey = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidIssuer = jwtConfig.Issuer,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtConfig.Secret)),
                ValidAudience = jwtConfig.Audience,
                ClockSkew = TimeSpan.Zero
            };
            v.Events = new JwtBearerEvents
            {
                OnMessageReceived = context =>
                {
                    var accessToken = context.Request.Query["access_token"];

                    var path = context.HttpContext.Request.Path;
                    if (!string.IsNullOrEmpty(accessToken) && (path.StartsWithSegments("/hubs")))
                        context.Token = accessToken;

                    return Task.CompletedTask;
                }
            };
        });
    }
}