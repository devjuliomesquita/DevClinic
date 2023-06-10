using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Domain.DTO.Contacts
{
    public class CreateEmail_InputModel
    {
        /// <summary>
        /// E-mail do cliente.
        /// </summary>
        /// <example>juliocesarmcamilo@gmail.com</example>
        public string? Email { get; set; }
    }
}
