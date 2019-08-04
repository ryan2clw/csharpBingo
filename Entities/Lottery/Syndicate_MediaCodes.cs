using System;

namespace SpaBingo.Entities.Lottery
{
    public class Syndicate_MediaCodes
    {
        public int ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedByStaffID { get; set; }
        public int SyndicateID { get; set; }
        public int MediaCodeID { get; set; }

        public virtual Media_Codes Media_Codes { get; set; }
        public virtual Syndicate Syndicate { get; set; }
    }
}
