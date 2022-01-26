using Dashboard.Shared;
using FluentValidation;

namespace Dashboard.Infrastructure.Validations
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
