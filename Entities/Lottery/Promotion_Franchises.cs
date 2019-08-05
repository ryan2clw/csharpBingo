using System;

namespace SpaBingo.Entities.Lottery
{
    public class Promotion_Franchises
    {
        public int ID { get; set; }
        public byte[] Timestamp { get; set; }
        public Guid ReplicationID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int FranchiseID { get; set; }
        public int PromotionID { get; set; }
        public int ConfigurationID { get; set; }

        //public virtual Franchise Franchise { get; set; }
        public virtual Promotion Promotion { get; set; }
    }
}