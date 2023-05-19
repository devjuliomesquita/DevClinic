using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Domain.Entities
{
    public class Doctor : User
    {
        public string? Register { get; private set; }
        public virtual ICollection<Doctor_Speciality>? Specialities { get; private set; }
    }
}
