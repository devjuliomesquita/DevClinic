using DevClinic.Data.Context;
using DevClinic.Domain.Entities;
using DevClinic.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Data.Repository
{
    public class DoctorRepository : Repositorybase<Doctor>, IDoctorRepository
    {
        private readonly DevClinic_Context _context;
        public DoctorRepository(DevClinic_Context context) : base(context)
        {
            _context = context;
        }

        public Doctor GetDetails(int id)
        {
            return
                _context.Doctors
                .Include(x => x.Specialities)
                .Where(x => x.Id == id)
                .FirstOrDefault();
        }
    }
}
