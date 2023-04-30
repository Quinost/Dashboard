namespace Dashboard.Functions.Notifications.SendBug;
public class SendBugEvent : INotification
{
    public SendBugEvent(string message, string system)
    {
        Message = message;
        System = system;
        Date = DateTime.Now;
    }

    public string Message { get; }
    public string System { get; }
    public DateTime Date { get; }
}
