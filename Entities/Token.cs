using System;
namespace SpaBingo.Entities
{
    public class Token
    {
        public long ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid Token1 { get; set; }
        public DateTime? LastUsedOn { get; set; }
        public int? AllowedUseCount { get; set; }
        public int CurrentUseCount { get; set; }
        public int? ExpiresAfterSeconds { get; set; }
        public bool? IsSlidingExpiration { get; set; }
        public bool HasExpired { get; set; }
        public virtual Tokens_ForCustomers Tokens_ForCustomers { get; set; }

    }
}
