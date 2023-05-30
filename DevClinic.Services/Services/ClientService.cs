using AutoMapper;
using DevClinic.Domain.Entities;
using DevClinic.Domain.Interfaces.Repositories;
using DevClinic.Domain.Interfaces.Services;


namespace DevClinic.Services.Services
{
    public class ClientService : ServiceBase<Client>, IClientService
    {
        private readonly IMapper _mapper;
        private readonly IRepositoryBase<Client> _repositoryBase;
        private readonly IClientRepository _clientRepository;
        public ClientService(
            IMapper mapper, 
            IRepositoryBase<Client> repositoryBase,
            IClientRepository  clientRepository) : base(mapper, repositoryBase)
        {
            _mapper = mapper;
            _repositoryBase = repositoryBase;
            _clientRepository = clientRepository;
        }

    }
}
