namespace Hospital.Models.Common
{
    public class BaseEntity
    {
        public Guid Id { get; protected set; } = Guid.NewGuid();
        public DateTime CreatedDate { get; protected set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; protected set; } = DateTime.UtcNow;
    }
}
