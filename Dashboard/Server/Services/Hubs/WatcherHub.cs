﻿using Dashboard.Server.Services.Helpers;
using Dashboard.Shared;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Dashboard.Server.Services.Hubs
{
    public interface IWatcherHub
    {
        Task WatcherStatus(WatcherModel status);
    }
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
