using DevClinic.Data.Context;
using DevClinic.Domain.Entities;
using DevClinic.Manager.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Data.Repository
{
    public class SpecialityRepository : Repositorybase<Speciality>, ISpecialityRepository
    {
        private readonly DevClinic_Context _context;
        public SpecialityRepository(DevClinic_Context context) : base(context)
        {
            _context = context;
        }
    }
}
