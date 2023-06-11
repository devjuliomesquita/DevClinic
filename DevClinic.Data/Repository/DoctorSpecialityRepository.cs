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

        public async Task DeleteAsync(DoctorSpeciality entity)
        {
            _context.DoctorsSpecialities.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<DoctorSpeciality> GetSpecialityDoctorAsync(DoctorSpeciality doctorSpeciality)
        {
            var doctorId = await _context.Doctors.SingleOrDefaultAsync(c => c.Id == doctorSpeciality.DoctorId);
            var specialityId = await _context.Specialities.SingleOrDefaultAsync(c => c.Id == doctorSpeciality.SpecialityId);
            if(doctorId == null || specialityId == null)
            {
                return doctorSpeciality;
            }
            else
            {
                return await _context.DoctorsSpecialities
                                        .Where(ds => ds.DoctorId == doctorSpeciality.DoctorId && ds.SpecialityId == doctorSpeciality.SpecialityId)
                                        .FirstOrDefaultAsync();
            }
        }
    }
}
