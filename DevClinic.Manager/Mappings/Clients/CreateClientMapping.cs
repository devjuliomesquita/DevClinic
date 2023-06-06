using AutoMapper;
using DevClinic.Domain.DTO.Clients;
using DevClinic.Domain.Entities;

namespace DevClinic.Manager.Mappings.Clients
{
    public class CreateClientMapping : Profile
    {
        public CreateClientMapping()
        {
            CreateMap<CreateClient_InputModel, Client>()
                .ForMember(c => c.CreatedAt, c => c.MapFrom(c => DateTime.Now.Date))
                .ForMember(c => c.Active, c => c.MapFrom(c => true));

        }
        //private string Token()
        //{
        //    var token = Guid.NewGuid().ToString("N").ToUpper()[..6];
        //    return token;
        //}
    }
}
