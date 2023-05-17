using DevClinic.Domain.Entities;
using FluentValidation;

namespace DevClinic.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : BaseEntity
    {
        TOutputModel Add<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TOutputModel : class
            where TInputModel : class
            where TValidator : AbstractValidator<TEntity>;
        TOutputModel Update<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TOutputModel : class
            where TInputModel : class
            where TValidator : AbstractValidator<TEntity>;
        void Delete(int id);
        IEnumerable<TOutputModel> GetAll<TOutputModel>() where TOutputModel : class;
        TOutputModel GetById<TOutputModel>(int id) where TOutputModel : class;
    }
}
