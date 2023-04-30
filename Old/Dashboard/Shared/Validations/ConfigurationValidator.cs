using FluentValidation;

namespace Dashboard.Shared.Validations;

public class ConfigurationValidator : AbstractValidator<ConfigurationModel>
{
    public ConfigurationValidator()
    {
        RuleFor(v => v.WatcherWorkerDelayTime)
            .NotEmpty()
            .LessThan(60);

        RuleFor(v => v.TokenExpirationTime)
            .NotEmpty();
    }
}
