using System;
using System.Collections.Generic;

namespace SpaBingo.Entities
{
    public class Promotions_EventBonusing_Events
    {
        public int ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedByStaffID { get; set; }
        public int PromotionID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int EventTypeID { get; set; }
        public bool IsActive { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public DateTime? QualifyByDateTime { get; set; }
        public string BonusType { get; set; }
        public int CustomerBalanceTypeID { get; set; }
        public decimal BonusAmount { get; set; }
        public decimal MinimumQualifyingAmount { get; set; }
        public decimal MaximumBonusAwardAmount { get; set; }
        public decimal SpendMultiplier { get; set; }
        public string SpendMultiplierAmountType { get; set; }
        public virtual CustomerBalanceType CustomerBalanceType { get; set; }
        public virtual Promotions_EventBonusing_EventTypes Promotions_EventBonusing_EventTypes { get; set; }
    }
}