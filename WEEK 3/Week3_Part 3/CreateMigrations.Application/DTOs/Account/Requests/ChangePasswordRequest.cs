using CreateMigrations.Application.Helpers;
using CreateMigrations.Application.Interfaces;
using FluentValidation;

namespace CreateMigrations.Application.DTOs.Account.Requests
{
    public class ChangePasswordRequest
    {
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
    public class ChangePasswordRequestValidator : AbstractValidator<ChangePasswordRequest>
    {
        public ChangePasswordRequestValidator(ITranslator translator)
        {
            RuleFor(x => x.Password)
                .NotEmpty()
                .NotNull()
                .MinimumLength(6)
                .Matches(Regexs.Password)
                .WithName(p => translator[nameof(p.Password)]);

            RuleFor(x => x.ConfirmPassword)
                .Equal(x => x.Password)
                .Matches(Regexs.Password)
                .WithName(p => translator[nameof(p.ConfirmPassword)]);
        }
    }
}
