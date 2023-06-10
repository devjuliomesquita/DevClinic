

using DevClinic.Domain.DTO.Doctor;
using FluentValidation;

namespace DevClinic.Manager.Validator.Doctors
{
    public class CreateDoctor_Validator : AbstractValidator<CreateDoctor_InputModel>
    {
        public CreateDoctor_Validator()
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
            RuleFor(jv => jv.Sexo)
                .NotEmpty().WithMessage("Por favor entre com a letra F ou M.")
                .NotNull().WithMessage("Por favor entre com a letra F ou M.")
                .Must(IsMorF).WithMessage("Por favor entre com a letra F ou M.");
            RuleFor(jv => jv.BirthDate)
                .NotEmpty().WithMessage("Por favor entre com uma data.")
                .NotNull().WithMessage("Por favor entre com data.")
                .LessThan(DateTime.Now)
                .GreaterThan(DateTime.Now.AddYears(-130));
            RuleFor(jv => jv.CRM)
                .NotEmpty().WithMessage("Por favor entre com o CRM do Médico.")
                .NotNull().WithMessage("Por favor entre com o CRM do Médico.")
                .MaximumLength(13).WithMessage("CRM pode conter no máximo 13 caracteres.")
                .MinimumLength(12).WithMessage("CRM deve conter no mínimo 12 caractes caso esteja sem o espaço.");
            RuleFor(jv => jv.Specialities).NotEmpty().NotNull();
        }
        private bool IsMorF(char sexo)
        {
            return sexo == 'M' || sexo == 'F';
        }
    }
}
