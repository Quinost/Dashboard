using Dashboard.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Dashboard.Client.Services
{
    public interface IConfigurationService
    {
        ValueTask<ConfigurationModel> GetConfiguration();
        ValueTask UpdateConfiguration(ConfigurationModel model);
    }

    public class ConfigurationService : IConfigurationService
    {
        private readonly HttpClient httpClient;
        public ConfigurationService(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

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
