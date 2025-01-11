using System.ComponentModel.DataAnnotations;

namespace Polling.Domain.Model
{
    public class Voting : BaseModel
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        ICollection<VotingDetail> VotingDetail { get; set; }
    }
}
