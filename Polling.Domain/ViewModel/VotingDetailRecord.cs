using Polling.Domain.Model;

namespace Polling.Domain.ViewModel
{
    public record VotingDetailRecord(Guid Id,
        string Name,
        Guid VotingId,
        Voting? Voting = null) : RootRecord(Id);

}
