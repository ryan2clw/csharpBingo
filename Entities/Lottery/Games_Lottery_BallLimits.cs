using System;

namespace SpaBingo.Entities.Lottery
{
    public class Games_Lottery_BallLimits
    {
        public long ID { get; set; }
        public byte[] Timestamp { get; set; }
        public Guid ReplicationID { get; set; }
        public DateTime CreatedOn { get; set; }
        public long? CreatedByID { get; set; }
        public int? FranchiseID { get; set; }
        public int? OrderSourceID { get; set; }
        public string LottoGameTypeID { get; set; }
        public string B1 { get; set; }
        public string B2 { get; set; }
        public string B3 { get; set; }
        public string B4 { get; set; }
        public string B5 { get; set; }
        public string B6 { get; set; }
        public string B7 { get; set; }
        public string B8 { get; set; }
        public string B9 { get; set; }
        public string B10 { get; set; }
        public decimal? TotalLimit { get; set; }

        //public virtual Franchise Franchise { get; set; }
        public virtual Games_Lottery_GameTypes Games_Lottery_GameTypes { get; set; }

    }
}