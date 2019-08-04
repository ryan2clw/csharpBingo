using System;

namespace SpaBingo.Entities.Lottery
{
    public class Games_Lottery_Drawings_ExtraInfo
    { 
        public long DrawingID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal? MinimumAmountPerBet { get; set; }
        public decimal? MaximumAmountPerBet { get; set; }
        public string ExtraPrizes { get; set; }
        public int? MinimumNumberPerBall { get; set; }
        public int? MaximumNumberPerBall { get; set; }
        public short? Fractions { get; set; }
        public int? OrderValidDays { get; set; }
        public string Description { get; set; }
        public string EstimatedJackpot { get; set; }
        public string ImageURL { get; set; }

        public virtual Drawing Drawing { get; set; }
    }
}
