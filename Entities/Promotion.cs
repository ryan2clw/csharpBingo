using System;
using System.Collections.Generic;

namespace SpaBingo.Entities
{
    public class Promotion
    {
        public int ID { get; set; }
        public byte[] Timestamp { get; set; }
        public Guid ReplicationID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string InternalName { get; set; }
        public string PromotionName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Promotion_Franchises> Promotion_Franchises { get; set; }
    }
}