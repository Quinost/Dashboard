using Dashboard.Server.Authentication;
using Dashboard.Server.Authentication.JWT;
using Dashboard.Server.Context;
using Dashboard.Server.Context.Entity;
using Dashboard.Server.Services;
using Dashboard.Server.Services.Helpers;
using Dashboard.Server.Services.Hubs;
using Dashboard.Server.Services.Workers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration) 
            => Configuration = configuration;

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var jwtConfig = Configuration.GetSection("JwtTokenConfig").Get<JwtConfig>();

            services.AddDbContext<DataContext>(opts => opts.UseSqlite("Filename=DashboardDB.db"));

            //TODO: RoleStore
            services.AddIdentityCore<UserEntity>()
                    .AddUserStore<UserStore>();

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

            services.AddScoped<JwtTokenGenerator>();
            services.AddScoped<BugService>();

            services.AddSingleton<WatcherHelper>();
            services.AddSingleton(jwtConfig);

            services.AddHostedService<WatcherWorker>();

            services.AddControllers();
            services.AddRazorPages();
            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //TODO: Authentication
                endpoints.MapHub<WatcherHub>("/hubs/watcher");
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
