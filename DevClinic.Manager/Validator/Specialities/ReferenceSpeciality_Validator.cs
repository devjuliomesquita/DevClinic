using DevClinic.Domain.DTO.Speciality;
using FluentValidation;


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
