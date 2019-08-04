using System;

namespace SpaBingo.Entities.Lottery
{
    public class Report_ViewableInFranchises
    {
        public int Report_Item_ID { get; set; }
        public int FranchiseID { get; set; }
        public Guid ReplicationID { get; set; }

        public virtual Franchise Franchise { get; set; }
        public virtual Report_Items Report_Items { get; set; }
    }
}