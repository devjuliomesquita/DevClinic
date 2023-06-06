

using DevClinic.Domain.DTO.Clients;
using FluentValidation;

namespace DevClinic.Manager.Validator.Clients
{
    public class CreateClient_Validator : AbstractValidator<CreateClient_InputModel>
    {
        public CreateClient_Validator()
        {
            RuleFor(jv => jv.Name)
                .NotEmpty().WithMessage("Por favor entre com um Nome.")
                .NotNull().WithMessage("Por favor entre com um Nome.")
                .MaximumLength(100).WithMessage("Título pode conter no máximo 100 caracteres.")
                .MinimumLength(3).WithMessage("Título deve conter no mínimo 3 caractes.");
            RuleFor(jv => jv.CPF)
                .NotEmpty().WithMessage("Por favor entre com um CPF.")
                .NotNull().WithMessage("Por favor entre com um CPF.")
                .MaximumLength(11).WithMessage("Título pode conter no máximo 11 caracteres.");
            RuleFor(jv => jv.Email)
                .NotEmpty().WithMessage("Por favor entre com um E-mail.")
                .NotNull().WithMessage("Por favor entre com um E-mail.")
                .MaximumLength(100).WithMessage("Título pode conter no máximo 100 caracteres.")
                .EmailAddress();
            RuleFor(jv => jv.Phone)
                .NotEmpty().WithMessage("Por favor entre com um Telefone.")
                .NotNull().WithMessage("Por favor entre com um Telefone.")
                .MaximumLength(11).WithMessage("Título pode conter no máximo 11 caracteres.")
                .MinimumLength(8).WithMessage("Título deve conter no mínimo 8 caractes.");
            RuleFor(jv => jv.Sexo)
                .NotEmpty().WithMessage("Por favor entre com a letra F ou M.")
                .NotNull().WithMessage("Por favor entre com a letra F ou M.")
                .Must(IsMorF).WithMessage("Por favor entre com a letra F ou M.");
            RuleFor(jv => jv.BirthDate)
                .NotEmpty().WithMessage("Por favor entre com uma data.")
                .NotNull().WithMessage("Por favor entre com data.")
                .LessThan(DateTime.Now)
                .GreaterThan(DateTime.Now.AddYears(-130));
            RuleFor(jv => jv.Register)
                .NotEmpty().WithMessage("Por favor entre com a letra F ou M.")
                .NotNull().WithMessage("Por favor entre com a letra F ou M.")
                .MaximumLength(6).WithMessage("Registro pode conter no máximo 6 caracteres.");
            RuleFor(jv => jv.Plan)
                .NotEmpty().WithMessage("Por favor entre com o seu plano.")
                .NotNull().WithMessage("Por favor entre com o seu plano.")
                .MaximumLength(20).WithMessage("Título pode conter no máximo 20 caracteres.")
                .MinimumLength(3).WithMessage("Título deve conter no mínimo 3 caractes.");


        }

        private bool IsMorF(char sexo)
        {
            return sexo == 'M' || sexo == 'F';
        }
    }
}
