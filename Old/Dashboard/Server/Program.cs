using Dashboard.Data;
using Dashboard.Functions;
using Dashboard.Infrastructure.Helpers;
using Dashboard.Infrastructure.Hubs;
using Dashboard.Infrastructure.Middleware;
using Dashboard.Infrastructure.Workers;
using Dashboard.Server.Extensions;
using Dashboard.Server.Services.Identity;
using Dashboard.Server.Services.Interfaces;
using Dashboard.Shared.Validations;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var jwtConfig = builder.Configuration.GetSection("JwtTokenConfig").Get<JwtConfig>();

builder.Services.AddDbContext<DataContext>(opts => opts.UseSqlite("Filename=DashboardDB.db"));

builder.Services.AddIdentityWithStore();
builder.Services.AddJwtBearerToken(jwtConfig);

builder.Services.AddMediatRHandlers();

builder.Services.AddScoped<IIdentityService, IdentityService>();

builder.Services.AddSingleton<IBlackListJWT, BlackListJWT>();
builder.Services.AddSingleton<WatcherHelper>();
builder.Services.AddSingleton(jwtConfig);

builder.Services.AddHostedService<WatcherWorker>();
builder.Services.AddHostedService<BlackListWorker>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddControllers()
    .AddFluentValidation(opt =>
    {
        //Only eng
        //opt.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());


        //We dont want use standard validator because now we have FluentValidation
        //opt.RunDefaultMvcValidationAfterFluentValidationExecutes = false;
        opt.DisableDataAnnotationsValidation = true;
    });

builder.Services.AddValidatorsFromAssemblyContaining<RefreshTokenValidator>();

ValidatorOptions.Global.LanguageManager.Enabled = false;

builder.Services.AddRazorPages();
builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
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

app.UseMiddleware<TokenBlackListMiddleware>();

app.UseAuthentication();
app.UseAuthorization();

app.UseMiddleware<RequestResponseMiddleware>();

app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<WatcherHub>("/hubs/watcher");
    endpoints.MapRazorPages();
    endpoints.MapControllers();
    endpoints.MapFallbackToFile("index.html");
});

app.Run();
