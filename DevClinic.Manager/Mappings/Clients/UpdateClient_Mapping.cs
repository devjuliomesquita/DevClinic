using AutoMapper;
using DevClinic.Domain.DTO.Clients;
using DevClinic.Domain.Entities;

namespace DevClinic.Manager.Mappings.Clients
{
    public class UpdateClient_Mapping : Profile
    {
        public UpdateClient_Mapping()
        {
            CreateMap<UpdateClient_InputModel, Client>()
                .ForMember(c => c.UpdatedAt, c => c.MapFrom(c => DateTime.Now));
        }
    }
}
