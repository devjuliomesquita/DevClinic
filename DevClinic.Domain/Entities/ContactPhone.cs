using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Domain.Entities
{
    public class ContactPhone
    {
        public int ClientId { get; private set; }
        public string? Phone { get; private set; }
        public Client? Client { get; private set; }
    }
}
