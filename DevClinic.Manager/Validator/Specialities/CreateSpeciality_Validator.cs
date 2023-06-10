using DevClinic.Domain.DTO.Speciality;
using FluentValidation;


namespace DevClinic.Manager.Validator.Specialities
{
    public class CreateSpeciality_Validator : AbstractValidator<CreateSpeciality_InputModel>
    {
        public CreateSpeciality_Validator()
        {
            RuleFor(s => s.NameSpeciality)
                .NotEmpty().WithMessage("Por favor entre com um Nome.")
                .NotNull().WithMessage("Por favor entre com um Nome.")
                .MaximumLength(30);
            RuleFor(s => s.DescriptionSpeciality)
                .NotEmpty().WithMessage("Por favor faça uma descrição da especialidade.")
                .NotNull().WithMessage("Por favor faça uma descrição da especialidade.")
                .MaximumLength(300);
        }
    }
}
