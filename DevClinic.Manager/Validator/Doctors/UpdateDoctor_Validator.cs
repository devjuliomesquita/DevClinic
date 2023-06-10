

using DevClinic.Domain.DTO.Doctor;
using FluentValidation;

namespace DevClinic.Manager.Validator.Doctors
{
    public class UpdateDoctor_Validator : AbstractValidator<UpdateDoctor_InputModel>
    {
        public UpdateDoctor_Validator()
        {
            RuleFor(d => d.Id)
                .NotNull().WithMessage("Por favor entre com um Id.")
                .NotEmpty().WithMessage("Por favor entre com um Id.")
                .GreaterThan(0).WithMessage("Por favor entre com um Id diferente de 0.");
            Include(new CreateDoctor_Validator());
        }
    }
}
