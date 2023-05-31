using DevClinic.Domain.Entities;


namespace DevClinic.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> AddAsync<TInputModel>(TInputModel inputModel) where TInputModel : class;
        Task<TEntity> UpdateAsync<TInputModel>(TInputModel inputModel) where TInputModel : class;
        Task DeleteAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
    }
}
