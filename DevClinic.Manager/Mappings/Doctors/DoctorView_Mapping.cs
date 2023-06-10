using AutoMapper;
using DevClinic.Domain.DTO.Doctor;
using DevClinic.Domain.Entities;


namespace DevClinic.Manager.Mappings.Doctors
{
    public class DoctorView_Mapping : Profile
    {
        public DoctorView_Mapping()
        {
            CreateMap<Doctor, Doctor_ViewModel>();
            CreateMap<Doctor, SpecialityDoctor_ViewModel>();
        }
    }
}
