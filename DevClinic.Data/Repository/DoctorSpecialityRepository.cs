using DevClinic.Data.Context;
using DevClinic.Domain.Entities;
using DevClinic.Manager.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace DevClinic.Data.Repository
{
    public class DoctorSpecialityRepository : IDoctorSpecialityRepository
    {
        private readonly DevClinic_Context _context;
        public DoctorSpecialityRepository(DevClinic_Context context)
        {
            _context = context;
        }
        public async Task<DoctorSpeciality> AddAsync(DoctorSpeciality entity)
        {
            await _context.DoctorsSpecialities.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<DoctorSpeciality> GetSpecialityDoctorAsync(DoctorSpeciality doctorSpeciality)
        {
            return
                await _context.DoctorsSpecialities
                    .Where(ds => ds.DoctorId == doctorSpeciality.DoctorId && ds.SpecialityId == doctorSpeciality.SpecialityId)
                    .FirstOrDefaultAsync();
        }
    }
}
