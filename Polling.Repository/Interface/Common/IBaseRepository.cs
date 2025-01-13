using Polling.Domain;

namespace Polling.Repository.Interface.Common
{
    public interface IBaseRepository<TModel> : IBaseReadOnlyRepository<TModel> where TModel : RootModel
    {
        Task CreateAsync(TModel model);
        Task ModifyAsync(TModel model);
        Task DeleteAsync(Guid id);
    }
}
