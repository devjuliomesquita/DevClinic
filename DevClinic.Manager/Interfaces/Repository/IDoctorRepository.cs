using DevClinic.Domain.Entities;

namespace DevClinic.Manager.Interfaces.Repository
{
    public interface IDoctorRepository : IRepositoryBase<Doctor>
    {
        Task<Doctor> GetDoctorByIdAsync(int id);
        Task<IEnumerable<Doctor>> GetAllDoctorsAsync();
        Task<Doctor> CreateDoctorAsync(Doctor doctor);
        Task<Doctor> UpdateDoctorAync(Doctor doctor);
        Task<DoctorSpeciality> GetSpecialityDoctor(DoctorSpeciality doctorSpeciality);
    }
}
