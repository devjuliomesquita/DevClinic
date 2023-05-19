using DevClinic.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Services.Validators
{
    public class SpecialityValidator :AbstractValidator<Speciality>
    {
        public SpecialityValidator()
        {
            RuleFor(s => s.NameSpeciality)
                .NotEmpty().WithMessage("Por favor entre com uma especialidade.")
                .NotNull().WithMessage("Por favor entre com uma especialidade.")
                .MaximumLength(100).WithMessage("Especialidade pode conter no máximo 100 caracteres.")
                .MinimumLength(3).WithMessage("Especialidade deve conter no mínimo 3 caractes.");
        }
    }
}
