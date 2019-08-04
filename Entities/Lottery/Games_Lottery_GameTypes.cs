using System;
using System.Collections.Generic;

namespace SpaBingo.Entities.Lottery
{
    public class Games_Lottery_GameTypes
    {
        public string ID { get; set; }
        public byte[] Timestamp { get; set; }
        public Guid ReplicationID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsDisplayed { get; set; }
        public string ImageID { get; set; }
        public bool AllowStraightBets { get; set; }
        public bool AllowBoxedBets { get; set; }
        public string DependentOnGameTypeID { get; set; }
        public string LotteryType { get; set; }
        public int? TranslationID { get; set; }
        public bool IsAffectedByDST { get; set; }
        public short? JackpotID { get; set; }
        public string InactiveReason { get; set; }
        public int GameTypeID { get; set; }
        public string Denominations { get; set; }
        public int? Games_Lottery_LotteryProviderGameType_ID { get; set; }
        public bool CanAutoPost { get; set; }
        public string AutoPostInactiveReason { get; set; }
        public int? Games_Lottery_GameTypeGroup_ID { get; set; }
        public int? PermutationCount { get; set; }
        public long? ScheduleGroupID { get; set; }
        public int? DrawingTimeOffsetMinutes { get; set; }
        public int? Games_Lottery_ExternalLottery_ID { get; set; }
        public decimal? ExtraPlayAddedAmount { get; set; }
        public int? LocalDrawingTimezoneID { get; set; }
        public string LocalDrawingTimezoneIANA { get; set; }
        public short? JackpotGroupID { get; set; }
        public short? Fractions { get; set; }
        public int? OrderValidDays { get; set; }
        public bool RequiresUniqueBalls { get; set; }
        public string EstimatedJackpot { get; set; }
        public string AllowedBallCountsOnOrder { get; set; }
        public string ImageURL { get; set; }
        public string Alias { get; set; }

        // public virtual ICollection<Games_Lottery_BallLimits> Games_Lottery_BallLimits { get; set; }
        // public virtual ICollection<Games_Lottery_Bigball_Payouts> Games_Lottery_Bigball_Payouts { get; set; }
        // public virtual ICollection<Games_Lottery_Games> Games_Lottery_Games { get; set; }
        // public virtual Games_Lottery_LotteryProviderGameTypes Games_Lottery_LotteryProviderGameTypes { get; set; }
        // public virtual ICollection<Games_Lottery_OrderDetails_ExtraData> Games_Lottery_OrderDetails_ExtraData { get; set; }
        // public virtual ICollection<Promotions_Lottery_FreeLines_ValidLotteryGameTypes> Promotions_Lottery_FreeLines_ValidLotteryGameTypes { get; set; }
    }
}
