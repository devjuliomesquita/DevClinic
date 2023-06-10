

using DevClinic.Domain.DTO.Speciality;

namespace DevClinic.Domain.DTO.Doctor
{
    public class Doctor_ViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? CPF { get; set; }
        public char Sexo { get; set; }
        public DateTime BirthDate { get; set; }
        public string? CRM { get; set; }
        public ICollection<Speciality_ViewModel>? Specialities { get; set; }
    }
}
