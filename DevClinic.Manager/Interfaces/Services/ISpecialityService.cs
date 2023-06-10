using DevClinic.Domain.DTO.Speciality;
using DevClinic.Domain.Entities;


namespace DevClinic.Manager.Interfaces.Services
{
    public interface ISpecialityService : IServiceBase<Speciality>
    {
        Task<SpecialityDetails_ViewModel> GetSpecialityByIdAsync(int id);
    }
}
