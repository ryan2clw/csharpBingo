using System;
using System.Collections.Generic;

namespace SpaBingo.Entities.Lottery
{
    public class Orders
    {

        public long ID { get; set; }
        public byte[] Timestamp { get; set; }
        public Guid ReplicationID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LocationID { get; set; }
        public int? StaffID { get; set; }
        public int? CreatedByID { get; set; }
        public DateTime? LastChangedOn { get; set; }
        public int? LastChangedByID { get; set; }
        public Guid Guid { get; set; }
        public int OrderSourceID { get; set; }
        public decimal? TotalPrice { get; set; }
        public bool IsVoid { get; set; }
        public long? ChainedFromOrderID { get; set; }
        public int? ThirdPartyID { get; set; }
        public long? ClientOrderID { get; set; }
        public bool IsPostedOffline { get; set; }
        public bool IsSystemVoid { get; set; }
        public bool IsOnPaymentPlan { get; set; }
        public Guid PaymentPlanGUID { get; set; }
        public bool CanNotBeVoided { get; set; }
        public DateTime? CanNotBeVoidedCreatedOn { get; set; }
        public string CanNotBeVoidedReason { get; set; }
        public string LotterySoftwareVersion { get; set; }
        public bool? IsReplayTicket { get; set; }
        public decimal TotalTaxPercentage { get; set; }
        public decimal TotalTaxCharged { get; set; }

        public virtual Customer Customers { get; set; }
        //public virtual Franchises Franchises { get; set; }
        public virtual ICollection<OrderDetails_Lottery> OrderDetails_Lottery { get; set; }
        public virtual ICollection<Syndicate_Orders> Syndicate_Orders { get; set; }
        public virtual ICollection<Transactions> Transactions { get; set; }
        //public virtual Orders_AdditionalInfo Orders_AdditionalInfo { get; set; }
    }
}
