using Dashboard.Client.Services.Interfaces;
using Dashboard.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Dashboard.Client.Services
{
    public class BugsService : IBugsService
    {
        private readonly HttpClient httpClient;

        public BugsService(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }
        public async Task<BugsWithCountModel> GetPaginatedBugs(int startIndex, int count)
        {
            return await httpClient.GetFromJsonAsync<BugsWithCountModel>($"api/bugs?startIndex={startIndex}&count={count}");
        }
    }
}
