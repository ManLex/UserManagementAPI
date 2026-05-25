using FluentValidation;
using UserManagementAPI.DTOs;

namespace UserManagementAPI.Validators
{
    public class UserCreateValidator : AbstractValidator<UserCreateDto>
    {
        public UserCreateValidator()
        {
            RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("Bad FullName")
                .MinimumLength(3).WithMessage("Min 3 char");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Bad Email")
                .EmailAddress().WithMessage("Bad Format Email");

            RuleFor(x => x.Role)
                .NotEmpty().WithMessage("Idk role");
        }
    }
}
