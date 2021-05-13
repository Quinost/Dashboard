using Dashboard.Server.Extensions;
using Dashboard.Server.Services;
using Dashboard.Server.Services.Helpers;
using Dashboard.Server.Services.Hubs;
using Dashboard.Server.Services.Workers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Dashboard.Infrastructure;
using Dashboard.Server.Services.Identity;
using Dashboard.Server.Services.Interfaces;
using System;
using FluentValidation.AspNetCore;
using System.Reflection;

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

            services.AddIdentityWithStore();
            services.AddJwtBearerToken(jwtConfig);

            services.AddScoped<IIdentityService, IdentityService>();
            services.AddScoped<IBugService, BugService>();
            services.AddScoped<IUserService, UserService>();

            services.AddSingleton<WatcherHelper>();
            services.AddSingleton(jwtConfig);

            services.AddHostedService<WatcherWorker>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddControllers()
                .AddFluentValidation(opt =>
            {
                opt.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
                //We dont want use standard validator because now we have FluentValidation
                opt.RunDefaultMvcValidationAfterFluentValidationExecutes = false;
                //Only eng
                opt.LocalizationEnabled = false;
            });

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
                endpoints.MapHub<WatcherHub>("/hubs/watcher");
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
