using Dashboard.Shared;

namespace Dashboard.Infrastructure.Hubs;
public interface IWatcherHub
{
    Task WatcherStatus(WatcherModel status);
}
