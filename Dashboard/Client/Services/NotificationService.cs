using Dashboard.Client.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Timers;

namespace Dashboard.Client.Services
{
    public class NotificationService : INotificationService
    {
        public event Action<RenderFragment, string> OnShow;

        public void ShowNotification(string message)
            => OnShow?.Invoke(builder => builder.AddContent(0, message), "info");
        public void ShowNotification(RenderFragment message) 
            => OnShow?.Invoke(message, "info");
        public void ShowSuccessNotification(string message) 
            => OnShow?.Invoke(builder => builder.AddContent(0, message), "success");
        public void ShowSuccessNotification(RenderFragment message)
            => OnShow?.Invoke(builder => builder.AddContent(0, message), "success");
        public void ShowErrorNotification(string message) 
            => OnShow?.Invoke(builder => builder.AddContent(0, message), "error");
        public void ShowErrorNotification(RenderFragment message) 
            => OnShow?.Invoke(builder => builder.AddContent(0, message), "error");
    }

    internal class NotificationModel
    {
        public Guid Id { get; set; }
        public RenderFragment Message { get; set; }
        public string Type { get; set; }

        public Action<Guid> RemoveNotification;

        private Timer timer;

        public NotificationModel(Action<Guid> remove)
        {
            RemoveNotification = remove;
            timer = new Timer();
            timer.Interval = 8000;
            timer.Elapsed += TimerElapsed;
            timer.Start();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            timer.Close();
            RemoveNotification(this.Id);
        }
    }
}
