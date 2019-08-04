using System;
using System.Collections.Generic;

namespace SpaBingo.Entities
{
    public class Syndicate_Queue
    {

        public long ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public long Syndicate_PeriodID { get; set; }
        public long CustomerAccountID { get; set; }
        public DateTime? BilledOn { get; set; }
        public long? TransactionID { get; set; }
        public bool WasPooled { get; set; }
        public long? FailedTransactionID { get; set; }
        public DateTime? NotifiedOn { get; set; }

        public virtual ICollection<Syndicate_Pool_Details> Syndicate_Pool_Details { get; set; }
        public virtual ICollection<Syndicate_Pool_Payouts> Syndicate_Pool_Payouts { get; set; }
        public virtual ICollection<Syndicate_Queue_Details> Syndicate_Queue_Details { get; set; }
    }
}
