using System;
using System.Collections.Generic;

namespace SpaBingo.Entities
{
    public class Customer_Billing_Queue
    {
        public long ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedByStaffID { get; set; }
        public int FranchiseID { get; set; }
        public int QueueTypeID { get; set; }
        public DateTime? PeriodIntendedDate { get; set; }
        public DateTime? StartedOn { get; set; }
        public DateTime? CompletedOn { get; set; }
        public DateTime? CanceledOn { get; set; }
        public int? CanceledByStaffID { get; set; }
        public string CanceledReason { get; set; }

        public virtual ICollection<Customer_Billing_Queue_Detail> Customer_Billing_Queue_Detail { get; set; }
    }
}