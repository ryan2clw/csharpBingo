using System.Collections.Generic;

namespace SpaBingo.Entities
{
    public class Games_Lottery_Drawings_Group
    {
        public long ID { get; set; }
        public byte[] Timestamp { get; set; }
        public System.Guid ReplicationID { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public virtual ICollection<Games_Lottery_Drawings> Games_Lottery_Drawings { get; set; }
    }
}
