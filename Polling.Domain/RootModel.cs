using System.ComponentModel.DataAnnotations;

namespace Polling.Domain
{
    public class RootModel
    {
        [Key]
        public Guid Id { get; set; }
    }
}
