using ApniDukaan.Core.RequestDTO;
using FluentValidation;

namespace ApniDukaan.Core.Validator
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            // Email validation
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");

            // Password validation
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters long.");

            // Confirm PersonName validation
            RuleFor(x => x.PersonName)
                .NotEmpty().WithMessage("Person name is required.")
                .MaximumLength(50).WithMessage("Person name must not exceed 50 characters.");

            // Gender validation
            RuleFor(x => x.Gender)
                .NotEmpty().WithMessage("Gender is required.")
                .IsInEnum().WithMessage("Invalid gender option. Valid options are: Male, Female, Other");
        }
    }
}
