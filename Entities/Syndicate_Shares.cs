using System;
using System.Collections.Generic;

namespace SpaBingo.Entities
{
    public class Syndicate_Shares
    {
        public long ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedByStaffID { get; set; }
        public int SyndicateGameLinkID { get; set; }
        public long CustomerAccountID { get; set; }
        public int ShareCount { get; set; }
        public int? NextShareCount { get; set; }
        public DateTime? LastBillingSuccess { get; set; }
        public bool IsClosed { get; set; }
        public DateTime? PauseStartDate { get; set; }
        public DateTime? PauseEndDate { get; set; }
        public DateTime? PurchasedOn { get; set; }
        public DateTime? CancellationRequestedOn { get; set; }
        public DateTime? CancellationOccursOn { get; set; }
        public long? CancellationRequestTransactionID { get; set; }
        public bool IsPromo { get; set; }
        public int? CancelAfterPooledCount { get; set; }
        public long? CancellationFlagTransactionID { get; set; }
        public int? Syndicate_Promo_LinkID { get; set; }
        public long? OrderID { get; set; }
        public DateTime? NotifiedOn { get; set; }

        public virtual ICollection<Syndicate_Queue_Details> Syndicate_Queue_Details { get; set; }
        public virtual ICollection<Syndicate_Share_Numbers> Syndicate_Share_Numbers { get; set; }
        public virtual Syndicate_Games_Link Syndicate_Games_Link { get; set; }
    }
}