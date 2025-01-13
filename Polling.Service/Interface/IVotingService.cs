using Polling.Domain.Model;
using Polling.Domain.ViewModel;
using Polling.Service.Interface.Common;

namespace Polling.Service.Interface
{
    public interface IVotingService : IBaseService<VotingRecord, Voting> 
    {
    }
}
