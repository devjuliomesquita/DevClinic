using AutoMapper;
using DevClinic.Domain.Entities;
using DevClinic.Manager.Interfaces.Repository;
using DevClinic.Manager.Interfaces.Services;

namespace DevClinic.Manager.Implementation
{
    public class ClientService : ServiceBase<Client>, IClientService
    {
        private readonly IMapper _mapper;
        private readonly IClientRepository _clientRepository;
        public ClientService(
            IMapper mapper,
            IRepositoryBase<Client> repositoryBase,
            IClientRepository clientRepository) : base(mapper, repositoryBase)
        {
            _mapper = mapper;
            _clientRepository = clientRepository;
        }

        public async Task<IEnumerable<Client>> GetAllClientAsync()
        {
            return
                await _clientRepository.GetAllClientsAsync();
        }

        public async Task<Client> GetClientByIdAsync(int id)
        {
            return
                await _clientRepository.GetClientByIdAsync(id);
        }
    }
}
