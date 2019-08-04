using System;

namespace SpaBingo.Entities
{
    public class Staff_AllowedFranchises
    {
        public long ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedByStaffID { get; set; }
        public DateTime? LastChangedOn { get; set; }
        public int? LastChangedByStaffID { get; set; }
        public int StaffID { get; set; }
        public int FranchiseID { get; set; }
        public int? LocationID { get; set; }

        public virtual Franchise Franchise { get; set; }
        public virtual Staff Staff { get; set; }
    }
}