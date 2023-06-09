﻿using AutoMapper;
using DevClinic.Domain.DTO.Addresses;
using DevClinic.Domain.DTO.Clients;
using DevClinic.Domain.DTO.Contacts;
using DevClinic.Domain.Entities;

namespace DevClinic.Manager.Mappings.Clients
{
    public class CreateClient_Mapping : Profile
    {
        public CreateClient_Mapping()
        {
            CreateMap<CreateClient_InputModel, Client>()
                .ForMember(c => c.CreatedAt, c => c.MapFrom(c => DateTime.Now))
                .ForMember(c => c.Active, c => c.MapFrom(c => true))
                .ForMember(c => c.BirthDate, c => c.MapFrom(c => c.BirthDate.Date));
            CreateMap<CreateAddress_InputModel, Address>();
            CreateMap<CreateEmail_InputModel, ContactEmail>();
            CreateMap<CreatePhone_InputModel, ContactPhone>();

        }
        //private string Token()
        //{
        //    var token = Guid.NewGuid().ToString("N").ToUpper()[..6];
        //    return token;
        //}
    }
}
