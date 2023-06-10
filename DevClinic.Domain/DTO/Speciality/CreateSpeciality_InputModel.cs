

namespace DevClinic.Domain.DTO.Speciality
{
    /// <summary>
    /// Objeto complexo para a criação de especialidade médica.
    /// </summary>
    public class CreateSpeciality_InputModel
    {
        /// <summary>
        /// Nome da Especialidade.
        /// </summary>
        /// <example>Ginecologia e Obstetrícia.</example>
        public string? NameSpeciality { get; set; }
        /// <summary>
        /// Descrição da especialidade.
        /// </summary>
        /// <example>Especialidade responsável tanto pela rotina de saúde da mulher, quanto da sua gestação, do parto e do puerpério (pós-parto).</example>
        public string? DescriptionSpeciality { get; set; }
    }
}
