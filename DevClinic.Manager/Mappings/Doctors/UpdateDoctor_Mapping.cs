

using AutoMapper;
using DevClinic.Domain.DTO.Doctor;
using DevClinic.Domain.Entities;

namespace DevClinic.Manager.Mappings.Doctors
{
    public class UpdateDoctor_Mapping : Profile
    {
        public UpdateDoctor_Mapping()
        {
            CreateMap<UpdateDoctor_InputModel, Doctor>()
                .ForMember(d =>d.UpdatedAt, d =>d.MapFrom(d => DateTime.Now));
        }
    }
}
