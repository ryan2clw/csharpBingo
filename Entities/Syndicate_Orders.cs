using System.Collections.Generic;

namespace SpaBingo.Entities
{
    public class Syndicate_Orders
    {
        public long ID { get; set; }
        public byte[] Timestamp { get; set; }
        public System.Guid ReplicationID { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long OrderID { get; set; }
        public long Syndicate_PoolID { get; set; }
        public virtual Order Order { get; set; }
        public virtual Syndicate_Pools Syndicate_Pools { get; set; }
        public virtual ICollection<Syndicate_Pool_Payouts> Syndicate_Pool_Payouts { get; set; }
    }
}