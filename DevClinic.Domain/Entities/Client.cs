using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Domain.Entities
{
    public class Client : User
    {
        public string? Register { get; private set; }
        public string? Plan { get; private set; }
    }
}
