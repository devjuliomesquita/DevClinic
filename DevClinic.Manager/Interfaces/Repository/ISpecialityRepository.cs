using DevClinic.Domain.Entities;


namespace DevClinic.Manager.Interfaces.Repository
{
    public interface ISpecialityRepository : IRepositoryBase<Speciality>
    {
        Task<Speciality> GetSpecialityByIdAsync(int id);
    }
}
