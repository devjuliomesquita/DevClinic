using DevClinic.Data.Context;
using DevClinic.Domain.Entities;
using DevClinic.Manager.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace DevClinic.Data.Repository
{
    public class SpecialityRepository : Repositorybase<Speciality>, ISpecialityRepository
    {
        private readonly DevClinic_Context _context;
        public SpecialityRepository(DevClinic_Context context) : base(context)
        {
            _context = context;
        }

        public async Task<Speciality> GetSpecialityByIdAsync(int id)
        {
            return
                await _context.Specialities.Include(s => s.Doctors).AsNoTracking().SingleOrDefaultAsync(s => s.Id == id);
        }
    }
}
