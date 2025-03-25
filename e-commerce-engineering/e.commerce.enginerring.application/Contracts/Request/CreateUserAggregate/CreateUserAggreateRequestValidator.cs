using FluentValidation;

namespace e_commerce_enginerring.application.Contracts.Request.CreateUserAggregate
{
    public class CreateUserAggreateRequestValidator : AbstractValidator<CreateUserAggregateRequest>
    {
        public CreateUserAggreateRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("O nome é obrigatório.")
                .MaximumLength(100).WithMessage("O nome deve ter no máximo 100 caracteres.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("O email é obrigatório.")
                .EmailAddress().WithMessage("O email informado não é válido.");

            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("O nome de usuário é obrigatório.")
                .MaximumLength(50).WithMessage("O nome de usuário deve ter no máximo 50 caracteres.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("A senha é obrigatória.")
                .MinimumLength(6).WithMessage("A senha deve ter pelo menos 6 caracteres.");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("O telefone é obrigatório.")
                .Matches(@"^\+?[1-9]\d{1,14}$").WithMessage("Número de telefone inválido.");

        }
    }
}

