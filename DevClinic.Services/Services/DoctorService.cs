using AutoMapper;
using DevClinic.Domain.Entities;
using DevClinic.Domain.Interfaces.Repositories;
using DevClinic.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Services.Services
{
    public class DoctorService : ServiceBase<Doctor>, IDoctorService
    {
        public DoctorService(
            IMapper mapper, 
            IRepositoryBase<Doctor> repositoryBase) : base(mapper, repositoryBase)
        {
        }
    }
}
