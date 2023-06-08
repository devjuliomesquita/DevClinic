using DevClinic.Data.Context;
using DevClinic.Domain.Entities;
using DevClinic.Manager.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace DevClinic.Data.Repository
{
    public class ClientRepository : Repositorybase<Client>, IClientRepository
    {
        private readonly DevClinic_Context _context;
        public ClientRepository(DevClinic_Context context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Client>> GetAllClientsAsync()
        {
            return
                await _context.Clients.Include(c => c.Address).AsNoTracking().ToListAsync();
        }

        public async Task<Client> GetClientByIdAsync(int id)
        {
            return
                await _context.Clients.Include(c => c.Address).SingleOrDefaultAsync(c => c.Id == id);
        }
    }
}
