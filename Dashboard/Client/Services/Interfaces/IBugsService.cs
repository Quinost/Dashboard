using Dashboard.Shared;

namespace Dashboard.Client.Services.Interfaces;

public interface IBugsService
{
    Task<BugsWithCountModel> GetPaginatedBugs(int startIndex, int count);
}
