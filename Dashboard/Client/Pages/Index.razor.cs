﻿using Dashboard.Client.Services;
using Dashboard.Client.Services.Interfaces;
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
    }
}
