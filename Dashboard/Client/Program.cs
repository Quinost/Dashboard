using Dashboard.Client;
using Dashboard.Client.Authentication;
using Dashboard.Client.Services;
using Dashboard.Client.Services.Interfaces;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<INotificationService, NotificationService>();
builder.Services.AddScoped<IConfigurationService, ConfigurationService>();
builder.Services.AddScoped<IBugsService, BugsService>();
builder.Services.AddScoped<IIdentityService, IdentityService>();
builder.Services.AddScoped<ITokenProvider, TokenProvider>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<JwtStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider, JwtStateProvider>(sp => sp.GetRequiredService<JwtStateProvider>());

builder.Services.AddScoped<JwtMessageHandler>();

builder.Services.AddScoped<JwtMessageHandler>();
builder.Services.AddHttpClient("API", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<JwtMessageHandler>();

builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>()
    .CreateClient("API"));

builder.Services.AddAuthorizationCore();

await builder.Build().RunAsync();
