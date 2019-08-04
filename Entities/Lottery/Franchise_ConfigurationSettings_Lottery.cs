using System;

namespace SpaBingo.Entities.Lottery
{
    public class Franchise_ConfigurationSettings_Lottery
    {
        public int FranchiseID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? LastModifiedByStaffID { get; set; }
        public bool AutoPoster_IsActive { get; set; }
        public string AutoPoster_Inactive_Reason { get; set; }

        public virtual Franchise Franchise { get; set; }
    }
}