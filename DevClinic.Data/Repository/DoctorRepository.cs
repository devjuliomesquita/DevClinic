using DevClinic.Data.Context;
using DevClinic.Domain.Entities;
using DevClinic.Manager.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace DevClinic.Data.Repository
{
    public class DoctorRepository : Repositorybase<Doctor>, IDoctorRepository
    {
        private readonly DevClinic_Context _context;
        public DoctorRepository(DevClinic_Context context) : base(context)
        {
            _context = context;
        }

        public async Task<Doctor> CreateDoctorAsync(Doctor doctor)
        {
            //await CreateDoctorSpecialiaty(doctor);
            await _context.Doctors.AddAsync(doctor);
            
            await _context.SaveChangesAsync();
            return doctor; 
        }

        public async Task<IEnumerable<Doctor>> GetAllDoctorsAsync()
        {
            return
                await _context.Doctors.Include(d => d.Specialities).AsNoTracking().ToListAsync();
        }

        public async Task<Doctor> GetDoctorByIdAsync(int id)
        {
            return
                await _context.Doctors.Include(d => d.Specialities).AsNoTracking().SingleOrDefaultAsync(d => d.Id == id);
        }

        public async Task<Doctor> UpdateDoctorAync(Doctor doctor)
        {
            var queryDoctor = await _context.Doctors.Include(d => d.Specialities).SingleOrDefaultAsync(d => d.Id == doctor.Id);
            if (queryDoctor == null) return null;
            _context.Entry(queryDoctor).CurrentValues.SetValues(doctor);
            await UpdateDoctorSpeciality(doctor, queryDoctor);
            await _context.SaveChangesAsync();
            return queryDoctor;
        }

        private async Task CreateDoctorSpecialiaty(Doctor doctor)
        {
            foreach (var speciality in doctor.Specialities)
            {
                var querySpeciality = await _context.Specialities.AsNoTracking().FirstAsync(s => s.Id == speciality.Id);
                _context.Entry(speciality).CurrentValues.SetValues(querySpeciality);
            }
        }
        private async Task UpdateDoctorSpeciality(Doctor doctor, Doctor queryDoctor)
        {
            queryDoctor.Specialities.Clear();
            foreach (var speciality in doctor.Specialities)
            {
                var querySpeciality = await _context.Specialities.FindAsync(speciality.Id);
                queryDoctor.Specialities.Add(querySpeciality);
            }
        }
    }
}
