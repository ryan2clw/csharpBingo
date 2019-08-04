using System;
using System.Collections.Generic;

namespace SpaBingo.Entities
{
    public class Syndicate_Pools
    {
        public long ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public long Syndicate_PeriodID { get; set; }
        public bool IsClosed { get; set; }

        public virtual ICollection<Syndicate_Orders> Syndicate_Orders { get; set; }
        public virtual Syndicate_Periods Syndicate_Periods { get; set; }
        public virtual ICollection<Syndicate_Pool_Details> Syndicate_Pool_Details { get; set; }
        public virtual ICollection<Syndicate_Pool_Numbers> Syndicate_Pool_Numbers { get; set; }
    }
}
