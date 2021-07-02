﻿using Dashboard.Server.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Server.Services.Middleware
{
    public class TokenBlackListMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IBlackListJWT _blackList;

        public TokenBlackListMiddleware(RequestDelegate next, IBlackListJWT blackList)
        {
            _next = next;
            _blackList = blackList;
        }

        public async Task Invoke(HttpContext context)
        {
            var auth = context.Request.Headers.FirstOrDefault(v => v.Key == HeaderNames.Authorization);

            if (!string.IsNullOrEmpty(auth.Key))
                if (_blackList.IsTokenOnBlackList(auth.Value))
                    context.Request.Headers.Remove(auth.Key);

            await _next(context);
        }
    }
}
