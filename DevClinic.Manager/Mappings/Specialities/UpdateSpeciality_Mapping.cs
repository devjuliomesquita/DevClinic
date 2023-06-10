using AutoMapper;
using DevClinic.Domain.DTO.Speciality;
using DevClinic.Domain.Entities;

namespace DevClinic.Manager.Mappings.Specialities
{
    public class UpdateSpeciality_Mapping : Profile
    {
        public UpdateSpeciality_Mapping()
        {
            CreateMap<UpdateSpeciality_InputModel, Speciality>();
        }
    }
}
