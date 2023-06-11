

namespace DevClinic.Domain.Entities
{
    public class DoctorSpeciality
    {
        public int DoctorId { get; private set; }
        public int SpecialityId { get; private set; }
        public Doctor? Doctors { get; private set; }
        public Speciality? Specialities { get; private set; }
    }
}
