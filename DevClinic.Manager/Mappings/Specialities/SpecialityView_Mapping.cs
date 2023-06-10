using AutoMapper;
using DevClinic.Domain.DTO.Speciality;
using DevClinic.Domain.Entities;

namespace DevClinic.Manager.Mappings.Specialities
{
    public class SpecialityView_Mapping : Profile
    {
        public SpecialityView_Mapping()
        {
            CreateMap<Speciality, Speciality_ViewModel>().ReverseMap();
            CreateMap<Speciality, SpecialityDetails_ViewModel>().ReverseMap();
            CreateMap<Speciality, ReferenceSpeciality>().ReverseMap();
        }
    }
}
