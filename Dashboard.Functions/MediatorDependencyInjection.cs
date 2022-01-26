using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Dashboard.Functions;
public static class MediatorDependencyInjection
{
    public static IServiceCollection AddMediatRHandlers(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        return services;
    }
}
