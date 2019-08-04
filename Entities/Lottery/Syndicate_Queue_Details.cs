using System;
using System.Collections.Generic;

namespace SpaBingo.Entities.Lottery
{
    public class Syndicate_Queue_Details
    {
        public long ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public long Syndicate_QueueID { get; set; }
        public long Syndicate_ShareID { get; set; }
        public int ShareCount { get; set; }

        public virtual Syndicate_Shares Syndicate_Shares { get; set; }
        public virtual Syndicate_Queue Syndicate_Queue { get; set; }
        public virtual ICollection<Syndicate_Queue_Numbers> Syndicate_Queue_Numbers { get; set; }
    }
}