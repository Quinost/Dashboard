using Dashboard.Client.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Client.Pages
{
    public partial class Index
    {
        [Inject] private INotificationService service {get;set;}
        public void Show()
        {
            service.ShowNotification("Test Notification");
        }
    }
}
