using Dashboard.Shared.Identity;
using FluentValidation;

namespace Dashboard.Shared.Validations;

public class RefreshTokenValidator : AbstractValidator<RefreshTokenRequest>
{
    public RefreshTokenValidator()
    {
        RuleFor(v => v.AccessToken)
            .NotEmpty()
            .WithMessage("An active/inactive access token is required to refresh the token");

        RuleFor(v => v.RefreshToken)
            .NotEmpty();
    }
}
