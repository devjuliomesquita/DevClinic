using AutoMapper;
using DevClinic.Domain.Entities;
using DevClinic.Services.DTO.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Services.AutoMapper.Clients
{
    public class UpdateClientMapping : Profile
    {
        public UpdateClientMapping()
        {
            CreateMap<ClientUpdate_InputModel, Client>()
                .ForMember(c => c.UpdatedAt, c => c.MapFrom(c => DateTime.Now));
        }
    }
}
