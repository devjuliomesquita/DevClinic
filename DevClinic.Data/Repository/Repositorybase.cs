using DevClinic.Data.Context;
using DevClinic.Domain.Entities;
using DevClinic.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinic.Data.Repository
{
    public class Repositorybase<TEntity> : IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        private readonly DevClinic_Context _context;
        public Repositorybase(DevClinic_Context context)
        {
            _context = context;
        }
        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Set<TEntity>().Remove(GetById(id));
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public IList<TEntity> GetAll()
        {
            return
                _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return
                _context.Set<TEntity>().Find(id);
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
