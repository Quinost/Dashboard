using Dashboard.Server.Services.Helpers;
using Dashboard.Server.Services.Hubs;
using Dashboard.Server.Services.Interfaces;
using Dashboard.Shared;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Dashboard.Server.Services.Workers
{
    public class WatcherWorker : BackgroundService
    {
        public readonly IHubContext<WatcherHub, IWatcherHub> Hub;
        private readonly WatcherHelper _helper;
        public WatcherModel model;
        private TimeSpan delayTime;

        //only for testing if client work properly
        private int i = 0;

        public WatcherWorker(IHubContext<WatcherHub, IWatcherHub> hub, WatcherHelper helper)
        {
            delayTime = TimeSpan.FromMinutes(1);
            Hub = hub;
            _helper = helper;
            _helper.OnDoAction += Helper_OnDoAction;
            _helper.OnDelayAction += Helper_OnDelayAction;
        }

        private int Helper_OnDelayAction(int? arg)
        {
            if (arg.HasValue)
                delayTime = TimeSpan.FromMinutes(arg.Value);
            return delayTime.Minutes;
        }

        private async void Helper_OnDoAction()
            => await Work();

        private async Task Work()
        {
            //make error to test hub client
            var model = new WatcherModel();
            if(i == 3)
            {
                model.StartTime = DateTime.Now;
                model.Error = true;
                model.ErrorTime = DateTime.Now;
                model.Message = "Test error";
                i = 0;
            }
            else
            {
                model.StartTime = DateTime.Now;
                model.Message = "Work";
                i++;
            }
            await Hub.Clients.All.WatcherStatus(model);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await Work();
                await Task.Delay(delayTime);
            }
        }
    }
}
