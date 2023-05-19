﻿using DevClinic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Domain.Interfaces.Repositories
{
    public interface ISpecialityRepository : IRepositoryBase<Speciality>
    {
        void AddSpeciality(Speciality speciality);
    }
}