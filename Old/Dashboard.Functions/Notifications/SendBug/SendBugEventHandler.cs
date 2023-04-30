using Dashboard.Infrastructure.Entity;

namespace Dashboard.Functions.Notifications.SendBug;
public class SendBugEventHandler : INotificationHandler<SendBugEvent>
{
    private readonly DataContext context;

    public SendBugEventHandler(DataContext context) 
        => this.context = context;

    public async Task Handle(SendBugEvent notification, CancellationToken cancellationToken)
    {
        context.Bugs.Add(new BugEntity
        {
            Date = notification.Date,
            Message = notification.Message,
            System = notification.System,
        });
        await context.SaveChangesAsync();
    }
}
