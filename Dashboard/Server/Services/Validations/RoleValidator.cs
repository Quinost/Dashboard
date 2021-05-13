using Dashboard.Shared;
using FluentValidation;

namespace Dashboard.Server.Services.Validations
{
    public class RoleValidator : AbstractValidator<RoleModel>
    {
        public RoleValidator()
        {
            RuleFor(v => v.Name).NotEmpty();
        }
    }
}
