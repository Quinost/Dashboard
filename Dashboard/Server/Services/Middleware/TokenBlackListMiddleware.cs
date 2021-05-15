using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Server.Services.Middleware
{
    public class TokenBlackListMiddleware
    {
        private readonly RequestDelegate _next;

        public TokenBlackListMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var auth = context.Request.Headers.FirstOrDefault(v => v.Key == "Authorization");
            if(!string.IsNullOrEmpty(auth.Key))
            {
                //context.Request.Headers.Remove(auth.Key);
            }
            await _next(context);
        }
    }
}
