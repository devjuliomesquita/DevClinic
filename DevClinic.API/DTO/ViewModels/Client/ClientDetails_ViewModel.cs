namespace DevClinic.API.DTO.ViewModels.Client
{
    public class ClientDetails_ViewModel
    {
        public string? Name { get; set; }
        public string? CPF { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public char Sexo { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? Register { get; set; }
        public string? Plan { get; set; }
    }
}
