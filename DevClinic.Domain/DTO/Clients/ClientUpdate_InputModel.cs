using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Domain.DTO.Clients
{
    public class ClientUpdate_InputModel : ClientCreate_InputModel
    {
        public int Id { get; set; }

    }
}
