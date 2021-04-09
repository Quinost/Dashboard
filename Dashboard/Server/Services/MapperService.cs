using Dashboard.Server.Context.Entity;
using Dashboard.Shared;
using System.Collections.Generic;
using System.Linq;

namespace Dashboard.Server.Services
{
    public static class MapperService
    {
        public static IEnumerable<BugModel> ToBugModel(this List<BugEntity> bugs)
            => bugs.Select(v => new BugModel { Id = v.Id, Date = v.Date, Message = v.Message, System = v.System });
    }
}
