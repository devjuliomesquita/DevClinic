using DevClinic.Domain.DTO.Doctor;
using DevClinic.Domain.Entities;


namespace DevClinic.Manager.Interfaces.Services
{
    public interface IDoctorSpecialityService
    {
        Task<DoctorSpeciality> AddSpecDoctorAsync<CreateSpecialityDoctor_InputModel>(CreateSpecialityDoctor_InputModel inputModel)
            where CreateSpecialityDoctor_InputModel : class;
        Task DeleteSpecDoctorAsync(CreateSpecialityDoctor_InputModel inputModel);
    }
}
