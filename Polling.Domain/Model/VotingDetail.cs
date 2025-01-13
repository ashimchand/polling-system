using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Polling.Domain.Model
{
    public class VotingDetail : RootModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public Guid VotingId { get; set; }

        [ForeignKey(nameof(VotingId))]
        public Voting Voting { get; set; }
    }
}
