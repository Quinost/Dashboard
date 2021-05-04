using Dashboard.Shared;
using System.Threading.Tasks;

namespace Dashboard.Client.Services.Interfaces
{
    public interface IBugsService
    {
        Task<BugsWithCountModel> GetPaginatedBugs(int startIndex, int count);
    }
}
