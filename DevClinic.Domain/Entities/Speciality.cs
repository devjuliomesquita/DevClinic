using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Domain.Entities
{
    public class Speciality : BaseEntity
    {
        public string? NameSpeciality { get; private set; }
        public int DoctorId { get; private set; }
    }
}
