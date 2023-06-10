

using DevClinic.Domain.DTO.Contacts;
using DevClinic.Domain.DTO.Speciality;

namespace DevClinic.Domain.DTO.Doctor
{
    /// <summary>
    /// Objeto complexo para a criação de um novo médico
    /// </summary>
    public class CreateDoctor_InputModel
    {
        /// <summary>
        /// Nome do Médico.
        /// </summary>
        /// <example>Júlio César de Mesquita Camilo Martins</example>
        public string? Name { get; set; }
        /// <summary>
        /// CPF do médico.
        /// </summary>
        /// <example>12345678945</example>
        public string? CPF { get; set; }
        /// <summary>
        /// Sexo do médico.
        /// </summary>
        /// <example>M</example>
        public char Sexo { get; set; }
        /// <summary>
        /// Data de nascimento do médico.
        /// </summary>
        /// <example>1994-11-12</example>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// CRM do médico.
        /// </summary>
        /// <example>CRM/CE 123456</example>
        public string? CRM { get; set; }
        public ICollection<ReferenceSpeciality>? Specialities { get; set; }
    }
}
