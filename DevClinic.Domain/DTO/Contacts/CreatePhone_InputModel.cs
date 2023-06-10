using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Domain.DTO.Contacts
{
    public class CreatePhone_InputModel
    {
        /// <summary>
        /// Telefone do cliente.
        /// </summary>
        /// <example>999886020</example>
        public string? Phone { get; set; }
    }
}
