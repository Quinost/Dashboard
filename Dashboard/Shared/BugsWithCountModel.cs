using System.Collections.Generic;

namespace Dashboard.Shared
{
    public class BugsWithCountModel
    {
        public int TotalCount { get; set; }
        public IEnumerable<BugModel> Bugs { get; set; }
    }
}
