using DevClinic.Data.Context;
using DevClinic.Domain.Entities;
using DevClinic.Manager.Interfaces.Repository;

namespace DevClinic.Data.Repository
{
    public class ClientRepository : Repositorybase<Client>, IClientRepository
    {
        private readonly DevClinic_Context _context;
        public ClientRepository(DevClinic_Context context) : base(context)
        {
            _context = context;
        }
    }
}
