using DevClinic.Domain.Entities;

namespace DevClinic.Manager.Interfaces.Services
{
    public interface IClientService : IServiceBase<Client>
    {
        Task<IEnumerable<Client>> GetAllClientAsync();
        Task<Client> GetClientByIdAsync(int id);
    }
}
