using System;

namespace SpaBingo.Entities.Lottery
{
    public class Syndicate_Promo_Link
    {
        public int ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedByStaffID { get; set; }
        public DateTime? ChangedOn { get; set; }
        public int? ChangedByStaffID { get; set; }
        public int FranchiseID { get; set; }
        public string Name { get; set; }
        public int Syndicate_ParentID { get; set; }
        public int Syndicate_PromoID { get; set; }
        public int? MediaCode_GroupID { get; set; }
        public int? Promo_CancelAfterPooledCount { get; set; }

        public virtual Franchise Franchise { get; set; }
        public virtual Media_Code_Groups Media_Code_Groups { get; set; }
        public virtual Syndicate Syndicate { get; set; }
        public virtual Syndicate Syndicate1 { get; set; }
    }
}
