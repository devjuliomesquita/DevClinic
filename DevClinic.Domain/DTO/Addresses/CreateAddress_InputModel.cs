

namespace DevClinic.Domain.DTO.Addresses
{
    public class CreateAddress_InputModel
    {
        /// <summary>
        /// CEP da sua residência sem o hífen.
        /// </summary>
        /// <example>61654325</example>
        public int CEP { get; set; }
        /// <summary>
        /// Nome da rua, travessa ou avenida.
        /// </summary>
        /// <example>Rua São Vicente de Paula</example>
        public string? Street { get; set; }
        /// <summary>
        /// Número da residência.
        /// </summary>
        /// <example>54 A</example>
        public string? Number { get; set; }
        /// <summary>
        /// Maior identificação para a residência.
        /// </summary>
        /// <example>Ap 1207</example>
        public string? Complement { get; set; }
        /// <summary>
        /// Cidade.
        /// </summary>
        /// <example>Caucaia</example>
        public string? City { get; set; }
        /// <summary>
        /// Estado.
        /// </summary>
        /// <example>Ceara</example>
        public string? State { get; set; }
    }
}
