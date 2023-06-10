using AutoMapper;
using DevClinic.Domain.DTO.Doctor;
using DevClinic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Manager.Mappings.Doctors
{
    public class DoctorView_Mapping : Profile
    {
        public DoctorView_Mapping()
        {
            CreateMap<Doctor, Doctor_ViewModel>();
        }
    }
}
