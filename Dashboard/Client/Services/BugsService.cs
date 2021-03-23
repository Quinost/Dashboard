using Dashboard.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Dashboard.Client.Services
{
    public class BugsService
    {
        private readonly HttpClient httpClient;

        public BugsService(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }
        //TODO: Add
        public async Task<IEnumerable<BugModel>> GetPaginatedBugs(int startIndex, int count)
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<BugModel>>($"api/bugs?startIndex={startIndex}&count={count}");
        }
    }
}
