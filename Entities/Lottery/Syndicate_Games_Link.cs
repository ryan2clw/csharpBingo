using System;
using System.Collections.Generic;

namespace SpaBingo.Entities.Lottery
{
    public class Syndicate_Games_Link
    {
        public int ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedByStaffID { get; set; }
        public int SyndicateID { get; set; }
        public int SyndicateGameID { get; set; }
        public string DisplayName { get; set; }
        public string ImageData { get; set; }
        public string ImageMimeType { get; set; }

        public virtual Syndicate Syndicate { get; set; }
        public virtual Syndicate_Games Syndicate_Games { get; set; }
        public virtual ICollection<Syndicate_Shares> Syndicate_Shares { get; set; }
    }
}