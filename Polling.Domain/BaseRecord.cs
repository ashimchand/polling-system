namespace Polling.Domain
{
    public record BaseRecord(
     Guid? CreatedBy,
     DateTime CreatedDate,
     string? ModifiedBy = null,
     DateTime? ModifiedDate = null
 );
}
