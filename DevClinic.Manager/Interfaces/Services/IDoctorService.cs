using DevClinic.Domain.Entities;


namespace DevClinic.Manager.Interfaces.Services
{
    public interface IDoctorService : IServiceBase<Doctor>
    {
        Task<Doctor> AddDoctorAsync<TInputModel>(TInputModel inputModel) where TInputModel : class;
        Task<Doctor> UpdateDoctorAsync<TInputModel>(TInputModel inputModel) where TInputModel : class;
        Task<IEnumerable<Doctor>> GetAllDoctorsAsync();
        Task<Doctor> GeDoctortByIdAsync(int id);
    }
}
