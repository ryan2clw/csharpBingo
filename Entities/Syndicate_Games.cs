using System;
using System.Collections.Generic;

namespace SpaBingo.Entities
{
    public class Syndicate_Games
    {
        public int ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedByStaffID { get; set; }
        public DateTime? ChangedOn { get; set; }
        public int? ChangedByStaffID { get; set; }
        public string InternalName { get; set; }
        public long Games_Lottery_Games_ID { get; set; }
        public int PoolSize { get; set; }
        public decimal? CostPerShare { get; set; }
        public int LinesPerPool { get; set; }
        public int? MinPoolSizeForPurchase { get; set; }
        public int? LengthOfPrepPhaseDays { get; set; }
        public bool IsActive { get; set; }
        public bool IsClosed { get; set; }
        public bool IsFree { get; set; }
        public bool RequiresChoosingNumbers { get; set; }
        public bool RequiresMerchantShare { get; set; }
        public int FranchiseID { get; set; }
        public bool PerDrawingPeriods { get; set; }
        public bool IsDefault { get; set; }
        public bool FullPoolsNotRequired { get; set; }

        public virtual ICollection<Syndicate_Games_Link> Syndicate_Games_Link { get; set; }
        public virtual Franchise Franchise { get; set; }
        public virtual ICollection<Syndicate_Periods> Syndicate_Periods { get; set; }
        public virtual Games_Lottery_Games Games_Lottery_Games { get; set; }
        }
    }
