using Dashboard.Client.Services;
using Microsoft.AspNetCore.Components;

namespace Dashboard.Client.Pages
{
    public partial class Index
    {
        [Inject] 
        private INotificationService service { get; set; }
        public void Show()
        {
            service.ShowNotification("Test Notification");
            service.ShowSuccessNotification("Test success notification");
            service.ShowErrorNotification("Test error notification");
        }

        public bool CosTam { get; set; }
    }
}
