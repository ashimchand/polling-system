using Polling.Domain;

namespace Polling.Service.Interface.Common
{
    public interface IBaseReadOnlyService<TViewModel, TModel> where TViewModel : RootRecord
         where TModel : RootModel
    {
        Task<TViewModel> GetDataAsync(Guid id);
    }
}
