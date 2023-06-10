using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Domain.DTO.Speciality
{
    public class UpdateSpeciality_InputModel : CreateSpeciality_InputModel
    {
        public int Id { get; set; }
    }
}
