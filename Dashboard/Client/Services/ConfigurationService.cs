using Dashboard.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Dashboard.Client.Services
{
    public class ConfigurationService
    {
        private readonly HttpClient httpClient;
        public ConfigurationService(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        //TODO: Error validation

        public async ValueTask<ConfigurationModel> GetConfiguration()
        {
            return await httpClient.GetFromJsonAsync<ConfigurationModel>("/api/configuration");
        }

        public async ValueTask UpdateConfiguration(ConfigurationModel model)
        {
            var retVal = await httpClient.PostAsJsonAsync("/api/configuration", model);
        }
    }
}
