﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Domain.Entities
{
    public class User : BaseEntity
    {
        public string? Name { get; private set; }
        public string? CPF { get; private set; }
        public string? Email { get; private set; }
        public string? Phone { get; private set; }
        public char Sexo { get; private set; }
        public bool Active { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}