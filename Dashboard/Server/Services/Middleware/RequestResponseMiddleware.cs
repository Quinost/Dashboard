using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Net.Http.Headers;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Dashboard.Server.Services.Middleware
{
    public class RequestResponseMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestResponseMiddleware(RequestDelegate next) 
            => _next = next;

        public async Task InvokeAsync(HttpContext context)
        {
            var requestBodyStream = new MemoryStream();
            var originalRequestBody = context.Request.Body;
            await context.Request.Body.CopyToAsync(requestBodyStream);
            requestBodyStream.Seek(0, SeekOrigin.Begin);
            var requestBodyText = new StreamReader(requestBodyStream).ReadToEnd();

            string requestUrl = $"Request url: {UriHelper.GetDisplayUrl(context.Request)}\n";
            requestUrl += $":method: {context.Request.Method}\n";
            requestUrl += $":scheme: {context.Request.Scheme}\n";
            requestUrl += $":userAgent: {context.Request.Headers[HeaderNames.UserAgent]}\n";
            requestUrl += context.User.Identity is not null ? string.Empty : $":authorization: {context.Request.Headers[HeaderNames.Authorization]}\n";

            string body = string.IsNullOrWhiteSpace(requestBodyText) ? "Empty" : requestBodyText;

            //we dont want to log info from identitycontroller
            if (!UriHelper.GetDisplayUrl(context.Request).Contains("/auth/"))
                requestUrl += $"Body: {body}";
            else
                requestUrl += "Body: AUTH SECRET";

            Console.WriteLine($"[{DateTime.Now}] {requestUrl}");
            Console.WriteLine(string.Empty);

            requestBodyStream.Seek(0, SeekOrigin.Begin);
            context.Request.Body = requestBodyStream;

            await _next(context);
            context.Request.Body = originalRequestBody;
        }
    }
}
