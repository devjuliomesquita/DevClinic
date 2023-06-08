using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Domain.Entities
{
    public class Address 
    {
        public int UserId { get; set; }
        public int CEP { get; private set; }
        public string? Street { get; private set; }
        public string? Number { get; private set; }
        public string? Complement { get; private set; }
        public string? City { get; private set; }
        public string? State { get; private set; }
        public User? User { get; set; }
    }
}
