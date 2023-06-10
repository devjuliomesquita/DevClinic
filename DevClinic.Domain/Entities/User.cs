

namespace DevClinic.Domain.Entities
{
    public abstract class User : BaseEntity
    {
        public string? Name { get; private set; }
        public string? CPF { get; private set; }
        public char Sexo { get; private set; }
        public bool Active { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        
    }
}
