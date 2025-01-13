using Microsoft.Extensions.Logging;
using Polling.Domain.ViewModel;
using Polling.Repository.Interface;
using Polling.Service.Interface;

namespace Polling.Service.Implementation
{
    public class VotingService : IVotingService
    {
        private ILogger _logger;
        private readonly IVotingRepository _repo;
        public VotingService(IVotingRepository repo,
            ILogger logger)
        {
            _repo = repo;
            _logger = logger;
        }

        public Task CreateAsync(VotingRecord model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<VotingRecord?> GetDataAsync(Guid id)
        {
            try
            {
                var voting = await _repo.GetDataAsync(id);
                return voting == null ? null : new VotingRecord(voting.Id, voting.Name, voting.Description);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public Task ModifyAsync(VotingRecord model)
        {
            throw new NotImplementedException();
        }
    }
}
