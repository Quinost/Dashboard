using Dashboard.Shared;
using FluentValidation;

namespace Dashboard.Server.Services.Validations
{
    public class ConfigurationValidator : AbstractValidator<ConfigurationModel>
    {
        public ConfigurationValidator()
        {
            RuleFor(v => v.WatcherWorkerDelayTime).NotEmpty().LessThan(60);
            RuleFor(v => v.TokenExpirationTime).NotEmpty();
        }
    }
}
