using Polling.Domain.Model;

namespace Polling.Domain.ViewModel
{
    public record VotingRecord(Guid Id, 
        string Name, 
        string? Description = null, 
        ICollection<VotingDetail>? VotingDetail = null) : RootRecord(Id);

}
