using Dashboard.Client.Components;
using Microsoft.AspNetCore.Components;
using System;
using System.Timers;

namespace Dashboard.Client.Services
{
    public interface INotificationService
    {
        void ShowNotification(string message);
        void ShowNotification(RenderFragment message);
        event Action<RenderFragment> OnShow;
    }
    public class NotificationService : INotificationService
    {
        public event Action<RenderFragment> OnShow;

        public void ShowNotification(string message)
        {
            OnShow?.Invoke(builder => builder.AddContent(0, message));
        }
        public void ShowNotification(RenderFragment message)
        {
            OnShow.Invoke(message);
        }
    }

    internal class NotificationModel
    {
        public Guid Id { get; set; }
        public RenderFragment Message { get; set; }

        public Action<Guid> RemoveNotification;

        private Timer timer;

        public NotificationModel()
        {
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
