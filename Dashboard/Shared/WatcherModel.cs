using System;

namespace Dashboard.Shared
{
    public class WatcherModel
    {
        public DateTime StartTime { get; set; }
        public string Message { get; set; }
        public bool Error { get; set; } = false;
        public DateTime ErrorTime { get; set; }
    }
}
