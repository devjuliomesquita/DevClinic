namespace DevClinic.API.DTO.InputModels.Client
{
    public class ClientCreate_InputModel
    {
        public string? Name { get; set; }
        public string? CPF { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public char Sexo { get; set; }
        public bool Active { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string? Register { get; set; } = Guid.NewGuid().ToString("N").ToUpper()[..6];
        public string? Plan { get; set; }
    }
}
