using DevClinic.Domain.DTO.Addresses;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Manager.Validator.Address
{
    public class CreateAddress_Validator : AbstractValidator<CreateAddress_InputModel>
    {
        public CreateAddress_Validator()
        {
            RuleFor(a => a.CEP)
                .NotEmpty().WithMessage("Por favor informe o CEP.")
                .NotNull().WithMessage("Por favor informe o CEP.");
            RuleFor(a=> a.Street)
                .NotEmpty().WithMessage("Por favor informe o nome da sua rua, travessa ou Avenida.")
                .NotNull().WithMessage("Por favor informe o nome da sua rua, travessa ou Avenida.")
                .MaximumLength(100);
            RuleFor(a => a.Number)
                .MaximumLength(10);
            RuleFor(a => a.Complement)
                .MaximumLength(50);
            RuleFor(a => a.City)
                .NotEmpty().WithMessage("Por favor informe sua cidade.")
                .NotNull().WithMessage("Por favor informe sua cidade.")
                .MaximumLength(50);
            RuleFor(a => a.State)
                .NotEmpty().WithMessage("Por favor informe seu estado.")
                .NotNull().WithMessage("Por favor informe seu estado.")
                .MaximumLength(50);
        }
    }
}
