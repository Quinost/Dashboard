using Dashboard.Server.Services.Helpers;
using Dashboard.Server.Services.Interfaces;
using Dashboard.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Dashboard.Server.Services.Hubs
{
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
}
