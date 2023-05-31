using DevClinic.Domain.Entities;
using DevClinic.Services.DTO.Clients;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Services.Validators.Clients
{
    public class UpdateClientValidator : AbstractValidator<ClientUpdate_InputModel>
    {
        public UpdateClientValidator()
        {
            RuleFor(c => c.Id)
                .NotNull().WithMessage("Por favor entre com um Id.")
                .NotEmpty().WithMessage("Por favor entre com um Id.")
                .GreaterThan(0).WithMessage("Por favor entre com um Id diferente de 0.");
            Include(new ClientValidator());
        }
    }
}
