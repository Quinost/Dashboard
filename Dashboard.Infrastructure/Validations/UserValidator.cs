using Dashboard.Shared;
using FluentValidation;

namespace Dashboard.Infrastructure.Validations
{
    public class UserValidator : AbstractValidator<UserModel>
    {
        public UserValidator()
        {
            RuleFor(v => v.Username).NotEmpty().MinimumLength(3);
            RuleFor(v => v.IsActive).NotEmpty();
            RuleFor(v => v.RoleId).NotEmpty();
        }
    }
}
