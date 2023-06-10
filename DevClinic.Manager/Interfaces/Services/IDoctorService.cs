using DevClinic.Domain.DTO.Doctor;
using DevClinic.Domain.Entities;


namespace DevClinic.Manager.Interfaces.Services
{
    public interface IDoctorService : IServiceBase<Doctor>
    {
        Task<Doctor_ViewModel> AddDoctorAsync<CreateDoctor_InputModel>(CreateDoctor_InputModel inputModel) 
            where CreateDoctor_InputModel : class;
        Task<Doctor_ViewModel> UpdateDoctorAsync<UpdateDoctor_InputModel>(UpdateDoctor_InputModel inputModel) 
            where UpdateDoctor_InputModel : class;
        Task<IEnumerable<Doctor_ViewModel>> GetAllDoctorsAsync();
        Task<Doctor_ViewModel> GetDoctortByIdAsync(int id);
    }
}
