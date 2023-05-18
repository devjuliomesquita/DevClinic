namespace DevClinic.API.DTO.InputModels.Client
{
    public class ClientUpdate_InputModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? CPF { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public char Sexo { get; set; }
        public string? Plan { get; set; }
    }
}
