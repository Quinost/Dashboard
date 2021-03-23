using Dashboard.Client.Services;
using Dashboard.Shared;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Dashboard.Client.Pages
{
    public partial class Configuration
    {
        [Inject] 
        public ConfigurationService configurationService { get; set; }

        [Inject]
        public INotificationService notificationService { get; set; }

        private ConfigurationModel configurationModelTemp;

        [Range(0, int.MaxValue, ErrorMessage = "Enter valid integer number")]
        public string WatcherWorkerDelayTime { get; set; }


        protected override async Task OnInitializedAsync()
        {
            configurationModelTemp = await configurationService.GetConfiguration();
            WatcherWorkerDelayTime = configurationModelTemp.WatcherWorkerDelayTime.ToString();
            StateHasChanged();
        }

        protected async void OnValidSubmit()
        {
            var confg = new ConfigurationModel()
            {
                WatcherWorkerDelayTime = int.Parse(WatcherWorkerDelayTime)
            };
            await configurationService.UpdateConfiguration(confg);
            notificationService.ShowNotification("Updated successfully");
            configurationModelTemp = await configurationService.GetConfiguration();
            StateHasChanged();
        }
    }
}
