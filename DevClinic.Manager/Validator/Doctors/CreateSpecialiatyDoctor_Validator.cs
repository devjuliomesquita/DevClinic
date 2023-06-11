using DevClinic.Domain.DTO.Doctor;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Manager.Validator.Doctors
{
    public class CreateSpecialiatyDoctor_Validator : AbstractValidator<CreateSpecialityDoctor_InputModel>
    {
        public CreateSpecialiatyDoctor_Validator()
        {
            RuleFor(sd => sd.SpecialityId)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0)
                .WithMessage("Digite um Id Válido para a especialidade.");
            RuleFor(sd => sd.DoctorId)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0)
                .WithMessage("Digite um Id Válido para o médico.");
        }
    }
}
