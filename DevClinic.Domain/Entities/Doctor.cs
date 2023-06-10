

namespace DevClinic.Domain.Entities
{
    public class Doctor : User
    {
        public string? CRM { get; private set; }
        public ICollection<Speciality> Specialities { get; set; }

    }
}
