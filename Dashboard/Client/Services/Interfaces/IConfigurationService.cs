using Dashboard.Shared;

namespace Dashboard.Client.Services.Interfaces;

public interface IConfigurationService
{
    Task<ConfigurationModel> GetConfiguration();
    Task UpdateConfiguration(ConfigurationModel model);
}
