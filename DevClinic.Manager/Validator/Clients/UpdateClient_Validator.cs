

using DevClinic.Domain.DTO.Clients;
using FluentValidation;

namespace DevClinic.Manager.Validator.Clients
{
    public class UpdateClient_Validator : AbstractValidator<UpdateClient_InputModel>
    {
        public UpdateClient_Validator()
        {
            RuleFor(c => c.Id)
                .NotNull().WithMessage("Por favor entre com um Id.")
                .NotEmpty().WithMessage("Por favor entre com um Id.")
                .GreaterThan(0).WithMessage("Por favor entre com um Id diferente de 0.");
            Include(new CreateClient_Validator());
        }
    }
}
