using DevClinic.Data.Context;
using DevClinic.Domain.Entities;
using DevClinic.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Data.Repository
{
    public class ClientRepository : Repositorybase<Client>, IClientRepository
    {
        private readonly DevClinic_Context _context;
        public ClientRepository(DevClinic_Context context) : base(context)
        {
            _context = context;
        }

        public Client GetDetails(int id)
        {
            return
                _context.Clients
                .Where(c => c.Id == id)
                .FirstOrDefault();
        }
    }
}
