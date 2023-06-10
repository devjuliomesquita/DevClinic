using DevClinic.Domain.DTO.Doctor;


namespace DevClinic.Domain.DTO.Speciality
{
    public class SpecialityDetails_ViewModel : Speciality_ViewModel
    {
        public ICollection<SpecialityDoctor_ViewModel>? Doctors { get; set; }
    }
}
