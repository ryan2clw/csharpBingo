using System;

namespace SpaBingo.Entities
{
    public class Games_ProgressiveJackpots_Queue
    {
        public long ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public short JackpotID { get; set; }
        public long DrawingID { get; set; }
        public long? OrderID { get; set; }
        public decimal Amount { get; set; }
        public long? TransactionID { get; set; }
        public long? RelatedToTransactionID { get; set; }

        public virtual Transaction Transaction { get; set; }
    }
}