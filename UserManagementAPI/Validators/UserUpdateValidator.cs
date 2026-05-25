using FluentValidation;
using UserManagementAPI.DTOs;

namespace UserManagementAPI.Validators
{
    public class UserUpdateValidator : AbstractValidator<UserUpdateDto>
    {
        public UserUpdateValidator()
        {
            RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("Full name?")
                .MinimumLength(3);

            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.Role)
                .NotEmpty();
        }
    }
}
