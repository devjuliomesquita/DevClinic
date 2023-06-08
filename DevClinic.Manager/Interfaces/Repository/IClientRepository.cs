using DevClinic.Domain.Entities;

namespace DevClinic.Manager.Interfaces.Repository
{
    public interface IClientRepository : IRepositoryBase<Client>
    {
        Task<Client> GetClientByIdAsync(int id);
        Task<IEnumerable<Client>> GetAllClientsAsync();
    }
}
