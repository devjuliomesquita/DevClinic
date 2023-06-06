﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Services.DTO.Clients
{
    public class ClientCreate_InputModel
    {
        public string? Name { get; set; }
        public string? CPF { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public char Sexo { get; set; }
        public string? Plan { get; set; }
    }
}