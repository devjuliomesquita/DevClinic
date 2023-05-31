using AutoMapper;
using DevClinic.Domain.Entities;
using DevClinic.Services.DTO.Clients;


namespace DevClinic.Services.AutoMapper.Clients
{
    public class CreateClientMapping : Profile
    {
        public CreateClientMapping()
        {
            CreateMap<ClientCreate_InputModel, Client>()
                .ForMember(c => c.CreatedAt, c => c.MapFrom(c => DateTime.Now.Date))
                .ForMember(c => c.Active, c => c.MapFrom(c => true))
                .ForMember(c => c.Register, c => c.MapFrom(c => Token())) ;

        }
        private string Token()
        {
            var token = Guid.NewGuid().ToString("N").ToUpper()[..6];
            return token;
        }
    }
}
