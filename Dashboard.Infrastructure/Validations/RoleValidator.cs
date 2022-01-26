using Dashboard.Shared;
using FluentValidation;

namespace Dashboard.Infrastructure.Validations
{
    public class RoleValidator : AbstractValidator<RoleModel>
    {
        public RoleValidator()
        {
            RuleFor(v => v.Name).NotEmpty();
        }
    }
}
