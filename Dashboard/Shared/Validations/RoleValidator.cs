using Dashboard.Shared;
using FluentValidation;

namespace Dashboard.Shared.Validations;

public class RoleValidator : AbstractValidator<RoleModel>
{
    public RoleValidator()
    {
        RuleFor(v => v.Name)
            .NotEmpty();
    }
}
