

using DevClinic.Domain.DTO.Addresses;
using DevClinic.Domain.DTO.Contacts;

namespace DevClinic.Domain.DTO.Clients
{
    /// <summary>
    /// Objeto complexo utlizado para a criação de novos clientes.
    /// </summary>
    public class CreateClient_InputModel
    {
        /// <summary>
        /// Nome do cliente.
        /// </summary>
        /// <example>Júlio César de Mesquita Camilo Martins</example>
        public string? Name { get; set; }
        /// <summary>
        /// CPF do cliente.
        /// </summary>
        /// <example>12345678945</example>
        public string? CPF { get; set; }
        public CreateEmail_InputModel? Emails { get; set; }
        public CreatePhone_InputModel? Phones { get; set; }
        /// <summary>
        /// Sexo do cliente.
        /// </summary>
        /// <example>M</example>
        public char Sexo { get; set; }
        /// <summary>
        /// Data de nascimento do cliente.
        /// </summary>
        /// <example>1994-11-12</example>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// Código de registro do cliente.
        /// </summary>
        /// <example>abc123</example>
        public string? Register { get; set; }
        /// <summary>
        /// Tipo de plano do cliente.
        /// </summary>
        /// <example>Credenciada</example>
        public string? Plan { get; set; }
        public CreateAddress_InputModel? Address { get; set; }
    }
}
