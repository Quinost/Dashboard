using Dashboard.Shared;
using System.Threading.Tasks;

namespace Dashboard.Server.Services.Interfaces
{
    public interface IWatcherHub
    {
        Task WatcherStatus(WatcherModel status);
    }
}
