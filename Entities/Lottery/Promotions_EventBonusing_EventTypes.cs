using System;
using System.Collections.Generic;

namespace SpaBingo.Entities.Lottery
{
    public class Promotions_EventBonusing_EventTypes
    {

            public int ID { get; set; }
            public Guid ReplicationID { get; set; }
            public byte[] Timestamp { get; set; }
            public DateTime CreatedOn { get; set; }
            public string InternalName { get; set; }
            public string DisplayName { get; set; }
            public string Description { get; set; }
            public bool IsActive { get; set; }
            public bool CanBePercent { get; set; }
            public bool IsAllowedMultiple { get; set; }
            public virtual ICollection<Promotions_EventBonusing_Events> Promotions_EventBonusing_Events { get; set; }
    }
}