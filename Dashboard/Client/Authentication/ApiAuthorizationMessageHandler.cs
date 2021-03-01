using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Dashboard.Client.Authentication
{
    public class ApiAuthorizationMessageHandler : DelegatingHandler
    {
        private readonly NavigationManager navManager;

        public ApiAuthorizationMessageHandler(NavigationManager _navManager)
        {
            navManager = _navManager;
        }
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            //TODO: Configure to JWTBearer
            Console.WriteLine("Handler works");
            return base.SendAsync(request, cancellationToken);
        }
    }
}
