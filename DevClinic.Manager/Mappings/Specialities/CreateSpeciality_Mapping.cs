using AutoMapper;
using DevClinic.Domain.DTO.Speciality;
using DevClinic.Domain.Entities;

namespace DevClinic.Manager.Mappings.Specialities
{
    public class CreateSpeciality_Mapping : Profile
    {
        public CreateSpeciality_Mapping()
        {
            CreateMap<CreateSpeciality_InputModel, Speciality>();
        }
    }
}
