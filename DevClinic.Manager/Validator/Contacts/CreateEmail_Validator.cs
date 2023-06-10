

using DevClinic.Domain.DTO.Contacts;
using FluentValidation;

namespace DevClinic.Manager.Validator.Contacts
{
    public class CreateEmail_Validator : AbstractValidator<CreateEmail_InputModel>
    {
        public CreateEmail_Validator()
        {
            RuleFor(jv => jv.Email)
                .NotEmpty().WithMessage("Por favor entre com um E-mail.")
                .NotNull().WithMessage("Por favor entre com um E-mail.")
                .MaximumLength(100).WithMessage("Título pode conter no máximo 100 caracteres.")
                .EmailAddress();
        }
    }
}
