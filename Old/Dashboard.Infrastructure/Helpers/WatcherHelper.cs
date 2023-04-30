namespace Dashboard.Infrastructure.Helpers;
public class WatcherHelper
{
    public event Action OnDoAction;
    public event Func<int?, int> OnDelayAction;

    //Send info from Worker when someone connect to Hub (without waiting)
    public void OnConnected()
        => OnDoAction();

    //Refresh info when someone turn on/off service checked in worker
    public void OnRefresh()
        => OnDoAction();

    //Change worker wait time
    public int OnDelay(int? arg)
        => OnDelayAction(arg);
}
