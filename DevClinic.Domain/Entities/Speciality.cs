

namespace DevClinic.Domain.Entities
{
    public class Speciality : BaseEntity
    {
        public string? NameSpeciality { get; private set; }
        public string? DescriptionSpeciality { get;  private set; }
        public ICollection<Doctor> Doctors { get; set; }

    }
}
