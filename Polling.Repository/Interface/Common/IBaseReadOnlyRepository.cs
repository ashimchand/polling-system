using Polling.Domain;

namespace Polling.Repository.Interface.Common
{
    public interface IBaseReadOnlyRepository<TModel> where TModel : RootModel
    {
        Task<TModel> GetDataAsync(Guid id);
    }
}
