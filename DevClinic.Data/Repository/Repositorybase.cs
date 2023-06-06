using DevClinic.Data.Context;
using DevClinic.Domain.Entities;
using DevClinic.Manager.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;


namespace DevClinic.Data.Repository
{
    public class Repositorybase<TEntity> : IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        private readonly DevClinic_Context _context;
        public Repositorybase(DevClinic_Context context)
        {
            _context = context;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entityConsultado = await _context.Set<TEntity>().FindAsync(id);
            _context.Set<TEntity>().Remove(entityConsultado);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
            
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var entityConsultado = await _context.Set<TEntity>().FindAsync(entity.Id);
            if (entityConsultado == null)
            {
                return null;
            }

            _context.Entry(entityConsultado).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();
            return entityConsultado;
        }
    }
}
