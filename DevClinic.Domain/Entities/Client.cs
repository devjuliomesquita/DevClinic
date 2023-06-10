

namespace DevClinic.Domain.Entities
{
    public class Client : User
    {
        public string? Register { get; private set; }
        public string? Plan { get; private set; }
        public ICollection<ContactEmail>? ContactEmails { get; private set; }
        public ICollection<ContactPhone>? ContactPhones { get; private set; }
        public Address? Address { get; private set; }
    }
}
