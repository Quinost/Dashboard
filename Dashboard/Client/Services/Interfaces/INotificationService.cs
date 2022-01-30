using Microsoft.AspNetCore.Components;

namespace Dashboard.Client.Services.Interfaces;

public interface INotificationService
{
    void ShowNotification(string message);
    void ShowNotification(RenderFragment message);
    void ShowSuccessNotification(string message);
    void ShowSuccessNotification(RenderFragment message);
    void ShowErrorNotification(string message);
    void ShowErrorNotification(RenderFragment message);

    event Action<RenderFragment, string> OnShow;
}
