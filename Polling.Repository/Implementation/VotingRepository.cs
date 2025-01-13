using Microsoft.EntityFrameworkCore;
using Polling.Domain.Model;
using Polling.Repository.Implementation.Common;
using Polling.Repository.Interface;

namespace Polling.Repository.Implementation
{
    public class VotingRepository : BaseRepository<Voting>, IVotingRepository
    {
        public VotingRepository(ApplicationDbContext context) : base(context)
        {
        }

        public override async Task<Voting> GetDataAsync(Guid id)
        {
            return await _context.Set<Voting>().Include(x => x.VotingDetail)
               .AsNoTracking()
               .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
