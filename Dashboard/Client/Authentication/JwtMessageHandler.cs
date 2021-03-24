using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Dashboard.Client.Authentication
{
    public class JwtMessageHandler : DelegatingHandler
    {
        private readonly NavigationManager navigationManager;
        private readonly IJSRuntime jsRuntime;


        public JwtMessageHandler(NavigationManager _navigationManager, IJSRuntime _jsRuntime)
        {
            navigationManager = _navigationManager;
            jsRuntime = _jsRuntime;
            //Cant DI AccountService ?????
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var token = await jsRuntime.InvokeAsync<string>("localStorage.getItem", "authToken");

            request.Headers.Authorization = new AuthenticationHeaderValue("bearer", token);

            var retVal = await base.SendAsync(request, cancellationToken);
            if (retVal.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                //need to change for something better
                navigationManager.NavigateTo("/logout", true);
            }

            return retVal;
        }
    }
}
