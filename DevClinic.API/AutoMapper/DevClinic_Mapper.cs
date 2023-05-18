using AutoMapper;
using DevClinic.API.DTO.InputModels.Client;
using DevClinic.API.DTO.ViewModels.Client;
using DevClinic.Domain.Entities;

namespace DevClinic.API.AutoMapper
{
    public class DevClinic_Mapper : Profile
    {
        public DevClinic_Mapper()
        {
            //Input - Clientes
            CreateMap<ClientCreate_InputModel, Client>();
            CreateMap<ClientUpdate_InputModel, Client>();

            //View - Clientes
            CreateMap<Client, Client_ViewModel>();
            CreateMap<Client, ClientDetails_ViewModel>();
            CreateMap<Client, ClientStandard_ViewModel>();
        }
    }
}
