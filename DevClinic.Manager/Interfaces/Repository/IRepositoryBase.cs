using DevClinic.Domain.Entities;

namespace DevClinic.Manager.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : BaseEntity
    {
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task DeleteAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
    }
}
