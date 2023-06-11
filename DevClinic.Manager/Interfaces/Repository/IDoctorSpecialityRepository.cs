
using DevClinic.Domain.Entities;

namespace DevClinic.Manager.Interfaces.Repository
{
    public interface IDoctorSpecialityRepository
    {
        Task<DoctorSpeciality> AddAsync(DoctorSpeciality entity);
        Task DeleteAsync(int id);
        Task<DoctorSpeciality> GetSpecialityDoctorAsync(DoctorSpeciality doctorSpeciality);
    }
}
