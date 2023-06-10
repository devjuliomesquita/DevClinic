using DevClinic.Domain.DTO.Speciality;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Manager.Validator.Specialities
{
    public class UpdateSpeciality_Validator : AbstractValidator<UpdateSpeciality_InputModel>
    {
        public UpdateSpeciality_Validator()
        {
            RuleFor(d => d.Id)
                .NotNull().WithMessage("Por favor entre com um Id.")
                .NotEmpty().WithMessage("Por favor entre com um Id.")
                .GreaterThan(0).WithMessage("Por favor entre com um Id diferente de 0.");
            Include(new CreateSpeciality_Validator());
        }
    }
}
