using Dashboard.Client.Services.Interfaces;
using Dashboard.Shared;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace Dashboard.Client.Pages
{
    public partial class Configuration
    {
        [Inject] 
        public IConfigurationService configurationService { get; set; }

        [Inject]
        public INotificationService notificationService { get; set; }

        private ConfigurationModel configurationModelTemp;

        [Range(0, int.MaxValue, ErrorMessage = "Enter valid integer number")]
        public string WatcherWorkerDelayTime { get; set; }

        public string AccessTokenExpirationTime { get; set; }


        protected override async Task OnInitializedAsync()
        {
            configurationModelTemp = await configurationService.GetConfiguration();
            WatcherWorkerDelayTime = configurationModelTemp.WatcherWorkerDelayTime.ToString();
            AccessTokenExpirationTime = configurationModelTemp.TokenExpirationTime.ToString();
            StateHasChanged();
        }

        protected async void OnValidSubmit()
        {
            var confg = new ConfigurationModel()
            {
                WatcherWorkerDelayTime = int.Parse(WatcherWorkerDelayTime)
            };
            await configurationService.UpdateConfiguration(confg);
            notificationService.ShowNotification("Configuration updated successfully");
            configurationModelTemp = await configurationService.GetConfiguration();
            StateHasChanged();
        }
    }
}
