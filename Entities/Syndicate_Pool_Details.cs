using System;

namespace SpaBingo.Entities
{
    public class Syndicate_Pool_Details
    {
        public long ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public long Syndicate_PoolID { get; set; }
        public long? Syndicate_QueueID { get; set; }
        public DateTime? CustomerNotifiedOn { get; set; }
        public long? Removed_Syndicate_QueueID { get; set; }
        public DateTime? RemovedOn { get; set; }

        public virtual Syndicate_Pools Syndicate_Pools { get; set; }
        public virtual Syndicate_Queue Syndicate_Queue { get; set; }
    }
}
