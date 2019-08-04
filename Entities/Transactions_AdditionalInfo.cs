using System;

namespace SpaBingo.Entities
{
    public class Transactions_AdditionalInfo
    {
        public long ID { get; set; }
        public string Notes { get; set; }
        public string ForwardingNotes { get; set; }
        public string ReviewNotes { get; set; }
        public Guid ReplicationID { get; set; }

        public virtual Transaction Transaction { get; set; }
    }
}