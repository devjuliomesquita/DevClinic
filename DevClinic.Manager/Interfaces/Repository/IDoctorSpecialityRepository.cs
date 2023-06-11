
using DevClinic.Domain.Entities;

namespace DevClinic.Manager.Interfaces.Repository
{
    public interface IDoctorSpecialityRepository
    {
        Task<DoctorSpeciality> AddAsync(DoctorSpeciality entity);
        Task DeleteAsync(DoctorSpeciality entity);
        Task<DoctorSpeciality> GetSpecialityDoctorAsync(DoctorSpeciality doctorSpeciality);
    }
}
