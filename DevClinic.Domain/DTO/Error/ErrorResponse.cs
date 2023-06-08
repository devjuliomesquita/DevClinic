using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Domain.DTO.Error
{
    public class ErrorResponse
    {
        public ErrorResponse(string id)
        {
            Id = id;
            DateError = DateTime.Now;
            Message = "Erro inesperado";
        }
        public string Id { get; set; }
        public DateTime DateError { get; set; }
        public string Message { get; set; }
    }
}
