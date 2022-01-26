using Dashboard.Infrastructure.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace Dashboard.Infrastructure.Hubs;

[Authorize]
public class WatcherHub : Hub<IWatcherHub>
{
    private readonly WatcherHelper helper;

    public WatcherHub(WatcherHelper _helper)
        => helper = _helper;

    public override Task OnConnectedAsync()
    {
        helper.OnConnected();
        return base.OnConnectedAsync();
    }
}
