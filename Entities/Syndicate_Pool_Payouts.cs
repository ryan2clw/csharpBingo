using System;

namespace SpaBingo.Entities
{
    public class Syndicate_Pool_Payouts
    {
        public long ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public long Syndicate_Order_ID { get; set; }
        public long? Syndicate_QueueID { get; set; }
        public decimal? PayoutTotal { get; set; }
        public bool IsPaid { get; set; }
        public long OrderDetails_Lottery_ID { get; set; }
        public long? Released_Syndicate_QueueID { get; set; }
        public DateTime? ReleasedOn { get; set; }
        public decimal? ConversionRate { get; set; }
        public DateTime? NotifiedOn { get; set; }

        public virtual Syndicate_Orders Syndicate_Orders { get; set; }
        public virtual Syndicate_Queue Syndicate_Queue { get; set; }
    }
}
