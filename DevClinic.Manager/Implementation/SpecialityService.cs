

using AutoMapper;
using DevClinic.Domain.DTO.Speciality;
using DevClinic.Domain.Entities;
using DevClinic.Manager.Interfaces.Repository;
using DevClinic.Manager.Interfaces.Services;

namespace DevClinic.Manager.Implementation
{
    public class SpecialityService : ServiceBase<Speciality>, ISpecialityService
    {
        private readonly IMapper _mapper;
        private readonly ISpecialityRepository _repository;
        public SpecialityService(IMapper mapper, IRepositoryBase<Speciality> repositoryBase, ISpecialityRepository repository) : base(mapper, repositoryBase)
        { 
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<SpecialityDetails_ViewModel> GetSpecialityByIdAsync(int id)
        {
            return
                _mapper.Map<SpecialityDetails_ViewModel>(await _repository.GetSpecialityByIdAsync(id));
        }
    }
}
