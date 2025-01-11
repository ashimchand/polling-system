using Microsoft.EntityFrameworkCore;
using Polling.Domain.Model;

namespace Polling.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                    : base(options)
        {
        }
        public DbSet<Voting> Voting { get; set; }
        public DbSet<VotingDetail> VotingDetail { get; set; }
    }
}
