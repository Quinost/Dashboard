using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Dashboard.Server.Services.Middleware
{
    public class RequestResponseMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestResponseMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine($"User: {context.User.Identity?.Name} request: '{context.Request.Path.Value}{context.Request.QueryString.Value}'");
            await _next(context);
        }
    }
}
