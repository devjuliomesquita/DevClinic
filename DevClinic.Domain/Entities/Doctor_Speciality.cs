using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Domain.Entities
{
    public class Doctor_Speciality
    {
        public int DoctorId { get; private set; }
        public int SpecilityId { get; private set; }
        public Doctor? Doctor { get; private set; }
        public Speciality? Speciality { get; private set; }
    }
}
