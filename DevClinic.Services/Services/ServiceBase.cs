using AutoMapper;
using DevClinic.Domain.Entities;
using DevClinic.Domain.Interfaces.Repositories;
using DevClinic.Domain.Interfaces.Services;


namespace DevClinic.Services.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : BaseEntity
    {
        private readonly IMapper _mapper;
        private readonly IRepositoryBase<TEntity> _repositoryBase;
        public ServiceBase(IMapper mapper, IRepositoryBase<TEntity> repositoryBase)
        {
            _mapper = mapper;
            _repositoryBase = repositoryBase;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            return await _repositoryBase.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repositoryBase.DeleteAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repositoryBase.GetAllAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _repositoryBase.GetByIdAsync(id);
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            return await _repositoryBase.UpdateAsync(entity);
        }
    }
}
