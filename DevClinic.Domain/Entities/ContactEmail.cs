using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Domain.Entities
{
    public class ContactEmail
    {
        public int ClientId { get; set; }
        public string? Email { get; private set; }
        public Client? Client { get; set; }
    }
}
