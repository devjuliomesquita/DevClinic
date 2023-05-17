using DevClinic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : BaseEntity
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        IList<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
