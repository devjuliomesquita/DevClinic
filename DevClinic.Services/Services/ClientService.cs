using AutoMapper;
using DevClinic.Domain.Entities;
using DevClinic.Domain.Interfaces.Repositories;
using DevClinic.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public TOutputModel GetDetails<TOutputModel>(int id) where TOutputModel : class
        {
            var entity = _clientRepository.GetDetails(id);
            TOutputModel outputModel = _mapper.Map<TOutputModel>(entity);
            return outputModel;
        }
    }
}
