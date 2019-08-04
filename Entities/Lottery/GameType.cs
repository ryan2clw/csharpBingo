using System;
using System.Collections.Generic;

namespace SpaBingo.Entities.Lottery
{
    public class GameType
    {
        public int ID { get; set; }
        public byte[] Timestamp { get; set; }
        public Guid ReplicationID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedByID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsDisplayed { get; set; }
        public int PayoutWindowInDays { get; set; }
        public string InactiveReason { get; set; }
        public int? TranslationID { get; set; }
        public bool IsAutoPostingEnabled { get; set; }
        public string AutoPostingInactiveReason { get; set; }
        public int? OrderLineItemLimit { get; set; }
        public int AdvancedPlayLimit { get; set; }

        public virtual ICollection<Drawing> Drawings { get; set; }
    }
}
