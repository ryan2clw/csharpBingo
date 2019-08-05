using System;
using System.Collections.Generic;

namespace SpaBingo.Entities.Lottery
{
    public class Games_Lottery_Games
    {

        public long ID { get; set; }
        public byte[] Timestamp { get; set; }
        public Guid ReplicationID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int FranchiseID { get; set; }
        public string LotteryGameTypeID { get; set; }
        public byte BallCount { get; set; }
        public string ClosesAtTime { get; set; }
        public string DrawsAtTime { get; set; }
        public bool DrawingOnSunday { get; set; }
        public bool DrawingOnMonday { get; set; }
        public bool DrawingOnTuesday { get; set; }
        public bool DrawingOnWednesday { get; set; }
        public bool DrawingOnThursday { get; set; }
        public bool DrawingOnFriday { get; set; }
        public bool DrawingOnSaturday { get; set; }
        public bool IsActive { get; set; }
        public bool IsDisplayed { get; set; }
        public decimal PayoutFactor { get; set; }
        public decimal? PayoutFactor2 { get; set; }
        public decimal? PayoutFactor3 { get; set; }
        public decimal? MaxBetLimit { get; set; }
        public int MinimumNumberPerBall { get; set; }
        public int MaximumNumberPerBall { get; set; }
        public decimal? MinimumAmountPerBet { get; set; }
        public decimal? MaximumAmountPerBet { get; set; }
        public byte? BallCountOnOrder { get; set; }
        public string LotteryType { get; set; }
        public short? JackpotID { get; set; }
        public bool IsManuallyCreated { get; set; }
        public int? ExtraBallCount { get; set; }
        public int? ExtraBallMinimumNumberPerBall { get; set; }
        public int? ExtraBallMaximumNumberPerBall { get; set; }
        public byte? MinimumBallCountOnOrder { get; set; }
        public byte? MaximumBallCountOnOrder { get; set; }
        public decimal? Grading_LowPercentage { get; set; }
        public decimal? Grading_HighPercentage { get; set; }
        public string Denominations { get; set; }
        public bool CanBeAutoPosted { get; set; }
        public decimal? OddsOfWinning { get; set; }
        public string AutoPostingInactiveReason { get; set; }
        public string InactiveReason { get; set; }
        public long? ScheduleGroupID { get; set; }
        public int? Games_Lottery_ExternalLottery_ID { get; set; }
        public decimal? ExtraPlayAddedAmount { get; set; }
        public string ClosesAtTime_DST { get; set; }
        public string DrawsAtTime_DST { get; set; }
        public int? CloseTimeOffset_Minutes { get; set; }
        public int? ExtraBallCountOnOrder { get; set; }
        public short? JackpotGroupID { get; set; }
        public short? Fractions { get; set; }
        public long? Games_Lottery_Games_GroupsID { get; set; }
        public int? StartTimeOffset_Minutes { get; set; }
        public int? OrderValidDays { get; set; }
        public bool IsDependentOnGame { get; set; }
        public string Dependent_LotteryGameTypeID { get; set; }
        public string NumberProviderIdentifier { get; set; }
        public string AllowedBallCountsOnOrder { get; set; }

        //public virtual Franchise Franchise { get; set; }
        //public virtual ICollection<Games_Lottery_Drawings> Games_Lottery_Drawings { get; set; }
        //public virtual ICollection<Games_Lottery_Games_BallAliases> Games_Lottery_Games_BallAliases { get; set; }
        //public virtual ICollection<Games_Lottery_Keno_Payouts> Games_Lottery_Keno_Payouts { get; set; }
        public virtual ICollection<Syndicate_Games> Syndicate_Games { get; set; }
        public virtual ICollection<OrderBundle_Detail> OrderBundle_Detail { get; set; }
        public virtual Games_Lottery_GameTypes Games_Lottery_GameTypes { get; set; }
    }
}