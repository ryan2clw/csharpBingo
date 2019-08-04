using System;
using System.Collections.Generic;

namespace SpaBingo.Entities
{
    public class Limits
    {
        public int ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedByStaffID { get; set; }
        public long? CreatedByCustomerID { get; set; }
        public string Name { get; set; }
        public DateTime? LimitCanBeAppliedOn { get; set; }
        public int? ApplyChangesToLimitID { get; set; }

        public virtual ICollection<Franchises> Franchises { get; set; }
        public virtual ICollection<LimitDetail> LimitDetails { get; set; }
        public virtual ICollection<CustomerAccounts> CustomerAccounts { get; set; }
        public virtual ICollection<CustomerAccounts> CustomerAccounts1 { get; set; }
    }
}