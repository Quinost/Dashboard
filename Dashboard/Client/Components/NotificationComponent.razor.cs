using Dashboard.Client.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dashboard.Client.Components
{
    public partial class NotificationComponent
    {
        private List<NotificationModel> Notifications { get; set; }

        [Inject]
        private INotificationService service { get; set; }

        public NotificationComponent()
        {
            //TODO: Fix the progress bar problem. When the older one ends the progress bar in the new notification disappears
            Notifications = new List<NotificationModel>();
        }

        protected override void OnInitialized()
        {
            service.OnShow += ShowToast;
            base.OnInitialized();
        }

        internal void ShowToast(RenderFragment message)
        {
            InvokeAsync(() =>
            {
                var toast = new NotificationModel
                {
                    Id = Guid.NewGuid(),
                    Message = message,
                };
                toast.RemoveNotification += Remove;
                Notifications.Add(toast);
                StateHasChanged();
            });
        }

        internal void Remove(Guid id)
        {
            Notifications.Remove(Notifications.FirstOrDefault(v => v.Id == id));
            StateHasChanged();
        }
    }
}
