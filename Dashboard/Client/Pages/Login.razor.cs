using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Dashboard.Client.Pages
{
    public partial class Login
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Inject]
        private NavigationManager navManager { get; set; }

        private string returnUrl { get; set; }

        /*
        [Inject]
        private AuthStateProvider authState { get; set; }
        */


        protected override async Task OnInitializedAsync()
        {
            var uri = navManager.ToAbsoluteUri(navManager.Uri);
            if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("returnUrl", out var _returnUrl))
                returnUrl = _returnUrl.ToString();

            /*
            var authstate = await authState.GetAuthenticationStateAsync();
            if (authstate.User.Identity.IsAuthenticated)
                navManager.NavigateTo("/");*/

            await base.OnInitializedAsync();
        }

        public async Task OnValidLogin()
        {
            Console.WriteLine(returnUrl);
            navManager.NavigateTo("/");
            await Task.CompletedTask;
        }
    }
}
