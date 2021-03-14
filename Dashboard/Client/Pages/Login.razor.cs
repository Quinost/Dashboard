using Microsoft.AspNetCore.Components;
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

        /*
        [Inject]
        private AuthStateProvider authState { get; set; }
        */

        public Login()
        {
        }

        protected override async Task OnInitializedAsync()
        {
            /*
            var authstate = await authState.GetAuthenticationStateAsync();
            if (authstate.User.Identity.IsAuthenticated)
                navManager.NavigateTo("/");*/
            await base.OnInitializedAsync();
        }

        public async Task OnValidLogin()
        {
            navManager.NavigateTo("/");
            await Task.CompletedTask;
        }
    }
}
