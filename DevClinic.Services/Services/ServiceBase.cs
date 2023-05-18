using AutoMapper;
using DevClinic.Domain.Entities;
using DevClinic.Domain.Interfaces.Repositories;
using DevClinic.Domain.Interfaces.Services;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public TOutputModel Add<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TInputModel : class
            where TOutputModel : class
            where TValidator : AbstractValidator<TEntity>
        {
            TEntity entity = _mapper.Map<TEntity>(inputModel);
            Validate(entity, Activator.CreateInstance<TValidator>()); // validando os dados
            _repositoryBase.Add(entity);
            TOutputModel outputModel = _mapper.Map<TOutputModel>(entity);
            return outputModel;
        }

        public void Delete(int id) => _repositoryBase.Delete(id);

        public IEnumerable<TOutputModel> GetAll<TOutputModel>() where TOutputModel : class
        {
            var entities = _repositoryBase.GetAll().ToList();
            var outputModel = entities.Select(e => _mapper.Map<TOutputModel>(e));
            return outputModel;
        }

        public TOutputModel GetById<TOutputModel>(int id) where TOutputModel : class
        {
            var entity = _repositoryBase.GetById(id);
            TOutputModel outputModel = _mapper.Map<TOutputModel>(entity);
            return outputModel;
        }

        public TOutputModel Update<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TInputModel : class
            where TOutputModel : class
            where TValidator : AbstractValidator<TEntity>
        {
            TEntity entity = _mapper.Map<TEntity>(inputModel);
            Validate(entity, Activator.CreateInstance<TValidator>());
            _repositoryBase.Update(entity);
            TOutputModel outputModel = _mapper.Map<TOutputModel>(entity);
            return outputModel;
        }

        //Validação
        private void Validate(TEntity entity, AbstractValidator<TEntity> validator)
        {
            if (entity == null)
            {
                throw new Exception("Registro não encontrado.");
            }
            validator.ValidateAndThrow(entity);
        }
    }
}
