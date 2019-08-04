using System;
using System.Collections.Generic;

namespace SpaBingo.Entities
{
    public class Media_Code_Groups
    {
        public int ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedByStaffID { get; set; }
        public int FranchiseID { get; set; }
        public string GroupKey { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public virtual Franchise Franchise { get; set; }
        public virtual ICollection<Syndicate_Promo_Link> Syndicate_Promo_Link { get; set; }
    }
}
