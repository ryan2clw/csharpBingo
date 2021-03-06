﻿using System;
using System.Collections.Generic;

namespace SpaBingo.Entities.Lottery
{
    public class Limit
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

        public virtual ICollection<LimitDetail> LimitDetails { get; set; }
        public virtual ICollection<CustomerAccount> CustomerAccounts { get; set; }
        //public virtual ICollection<CustomerAccount> CustomerAccounts1 { get; set; }
        public virtual ICollection<Franchise> Franchises { get; set; }
    }
}