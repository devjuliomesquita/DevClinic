using DevClinic.Domain.DTO.Contacts;
using FluentValidation;


namespace DevClinic.Manager.Validator.Contacts
{
    public class CreatePhone_Validator : AbstractValidator<CreatePhone_InputModel>
    {
        public CreatePhone_Validator()
        {
            RuleFor(jv => jv.Phone)
                .NotEmpty().WithMessage("Por favor entre com um Telefone.")
                .NotNull().WithMessage("Por favor entre com um Telefone.")
                .MaximumLength(11).WithMessage("Título pode conter no máximo 11 caracteres.")
                .MinimumLength(8).WithMessage("Título deve conter no mínimo 8 caractes.");
        }
    }
}
