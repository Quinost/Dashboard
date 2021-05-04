using Dashboard.Client.Services;
using Dashboard.Client.Services.Interfaces;
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

        public string ErrorMessage { get; set; }

        private string returnUrl { get; set; }

        [Inject]
        private NavigationManager navManager { get; set; }

        [Inject]
        private IIdentityService authService { get; set; }

        
        protected override async Task OnInitializedAsync()
        {
            var authstate = await authService.GetAuthState();
            if (authstate.User.Identity.IsAuthenticated)
                navManager.NavigateTo("/");

            await base.OnInitializedAsync();
        }

        public async Task OnValidLogin()
        {
            ErrorMessage = string.Empty;
            try
            {
                await authService.Login(Username, Password);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                StateHasChanged();
                return;
            }

            if (!string.IsNullOrWhiteSpace(returnUrl))
                navManager.NavigateTo(returnUrl);
            else
                navManager.NavigateTo("/");
            await Task.CompletedTask; 
        }
    }
}
