﻿using Dashboard.Client.Services;
using Dashboard.Client.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace Dashboard.Client.Components;

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

    internal void ShowToast(RenderFragment message, string type)
    {
        InvokeAsync(() =>
        {
            var toast = new NotificationModel(Remove)
            {
                Id = Guid.NewGuid(),
                Message = message,
                Type = type
            };
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
