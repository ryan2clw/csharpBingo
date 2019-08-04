using System;
using System.Collections.Generic;

namespace SpaBingo.Entities.Lottery
{
    public class CustomerBalance
    {
        public long ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedByStaffID { get; set; }
        public long CustomerAccountID { get; set; }
        public int BalanceTypeID { get; set; }
        public decimal? Balance { get; set; }
        public int? BonusEventID { get; set; }
        public long? TransactionID { get; set; }
        public DateTime? StartCheckDate { get; set; }
        public int? RewardLevelID { get; set; }
        public virtual CustomerAccount CustomerAccount { get; set; }
        public virtual CustomerBalanceType CustomerBalanceType { get; set; }

    }
}
