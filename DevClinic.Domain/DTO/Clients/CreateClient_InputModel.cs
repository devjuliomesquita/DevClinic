

namespace DevClinic.Domain.DTO.Clients
{
    public class CreateClient_InputModel
    {
        public string? Name { get; set; }
        public string? CPF { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public char Sexo { get; set; }
        public string? Plan { get; set; }
    }
}
