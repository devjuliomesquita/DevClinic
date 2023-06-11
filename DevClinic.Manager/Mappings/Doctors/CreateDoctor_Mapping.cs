

using AutoMapper;
using DevClinic.Domain.DTO.Doctor;
using DevClinic.Domain.Entities;

namespace DevClinic.Manager.Mappings.Doctors
{
    public class CreateDoctor_Mapping : Profile
    {
        public CreateDoctor_Mapping()
        {
            CreateMap<CreateDoctor_InputModel, Doctor>()
                .ForMember(d =>d.CreatedAt, d =>d.MapFrom(d => DateTime.Now))
                .ForMember(d =>d.Active, d =>d.MapFrom(d => true))
                .ForMember(d =>d.BirthDate, d =>d.MapFrom(d => d.BirthDate.Date));
            CreateMap<CreateSpecialityDoctor_InputModel, DoctorSpeciality>();
        }
    }
}
