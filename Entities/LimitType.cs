using System;
using System.Collections.Generic;

namespace SpaBingo.Entities
{
    public class LimitType
    {
        public int ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedByStaffID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<LimitDetail> LimitDetails { get; set; }
    }
}
