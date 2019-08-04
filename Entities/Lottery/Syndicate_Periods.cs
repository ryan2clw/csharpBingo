using System;
using System.Collections.Generic;

namespace SpaBingo.Entities.Lottery
{
    public class Syndicate_Periods
    {
        public long ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public int SyndicateGameID { get; set; }
        public DateTime? PrepPeriodStartDate { get; set; }
        public DateTime? PlayPeriodStartDate { get; set; }
        public DateTime? PlayPeriodEndDate { get; set; }
        public long? DrawingID { get; set; }
        public DateTime? PeriodIntendedDate { get; set; }
        public long? Previous_PeriodID { get; set; }
        public bool QueueingComplete { get; set; }
        public DateTime? LastOrderDate { get; set; }
        public DateTime? PreviousWinningsLastDate { get; set; }

        public virtual ICollection<Syndicate_Pools> Syndicate_Pools { get; set; }
        public virtual Syndicate_Games Syndicate_Games { get; set; }
    }
}
