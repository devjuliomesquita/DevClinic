using DevClinic.Domain.DTO.Speciality;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Manager.Validator.Specialities
{
    public class ReferenceSpeciality_Validator : AbstractValidator<ReferenceSpeciality>
    {
        public ReferenceSpeciality_Validator()
        {
            RuleFor(s => s.Id).NotNull().NotEmpty().GreaterThan(0);
        }
    }
}
