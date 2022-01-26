using Dashboard.Client.Services.Interfaces;
using Dashboard.Shared;
using System.Net.Http.Json;

namespace Dashboard.Client.Services;
public class ConfigurationService : IConfigurationService
{
    private readonly HttpClient httpClient;
    public ConfigurationService(HttpClient _httpClient)
    {
        httpClient = _httpClient;
    }

    public async Task<ConfigurationModel> GetConfiguration()
    {
        return await httpClient.GetFromJsonAsync<ConfigurationModel>("/api/configuration");
    }

    public async Task UpdateConfiguration(ConfigurationModel model)
    {
        var retVal = await httpClient.PostAsJsonAsync("/api/configuration", model);
    }
}
