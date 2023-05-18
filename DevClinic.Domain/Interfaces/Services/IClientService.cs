using DevClinic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Domain.Interfaces.Services
{
    public interface IClientService : IServiceBase<Client>
    {
        TOutputModel GetDetails<TOutputModel>(int id) where TOutputModel : class;
    }
}
