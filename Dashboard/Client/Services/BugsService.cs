using Dashboard.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Dashboard.Client.Services
{
    public interface IBugsService
    {
        Task<BugsWithTotalCountModel> GetPaginatedBugs(int startIndex, int count);
    }

    public class BugsService : IBugsService
    {
        private readonly HttpClient httpClient;

        public BugsService(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }
        public async Task<BugsWithTotalCountModel> GetPaginatedBugs(int startIndex, int count)
        {
            return await httpClient.GetFromJsonAsync<BugsWithTotalCountModel>($"api/bugs?startIndex={startIndex}&count={count}");
        }
    }
}
