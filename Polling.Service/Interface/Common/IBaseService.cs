using Polling.Domain;

namespace Polling.Service.Interface.Common
{
    public interface IBaseService<TViewModel, TModel> : IBaseReadOnlyService<TViewModel, TModel>
        where TViewModel : RootRecord
        where TModel : RootModel
    {
        Task CreateAsync(TViewModel model);
        Task ModifyAsync(TViewModel model);
        Task DeleteAsync(Guid id);
    }
}
