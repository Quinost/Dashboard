using Dashboard.Shared;
using System.Threading.Tasks;

namespace Dashboard.Client.Services.Interfaces
{
    public interface IConfigurationService
    {
        Task<ConfigurationModel> GetConfiguration();
        Task UpdateConfiguration(ConfigurationModel model);
    }
}
