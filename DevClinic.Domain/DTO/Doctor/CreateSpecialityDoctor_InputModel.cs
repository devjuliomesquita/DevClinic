

namespace DevClinic.Domain.DTO.Doctor
{
    public class CreateSpecialityDoctor_InputModel
    {
        /// <summary>
        /// Id do médico.
        /// </summary>
        /// <example>1</example>
        public int DoctorId { get; set; }
        /// <summary>
        /// Id da especialidade.
        /// </summary>
        /// <example>2</example>
        public int SpecialityId { get; set; }
    }
}
