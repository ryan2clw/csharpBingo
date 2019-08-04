using System;

namespace SpaBingo.Entities.Lottery
{
    public class OrderDetails_Lottery
    {
        public long ID { get; set; }
        public byte[] Timestamp { get; set; }
        public Guid ReplicationID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? LastChangedOn { get; set; }
        public long OrderID { get; set; }
        public long DrawingID { get; set; }
        public string B1 { get; set; }
        public string B2 { get; set; }
        public string B3 { get; set; }
        public string B4 { get; set; }
        public string B5 { get; set; }
        public string B6 { get; set; }
        public bool IsBoxed { get; set; }
        public decimal Price { get; set; }
        public decimal? FractionalPrice { get; set; }
        public short? CountOfCombinations { get; set; }
        public short? CountOfMatches { get; set; }
        public decimal? Payout { get; set; }
        public bool IsWinner { get; set; }
        public bool IsPaid { get; set; }
        public bool IsLoss { get; set; }
        public bool IsComped { get; set; }
        public string ReasonComped { get; set; }
        public string B7 { get; set; }
        public string B8 { get; set; }
        public string B9 { get; set; }
        public string B10 { get; set; }
        public bool ShouldBeRefunded { get; set; }
        public bool IsRefunded { get; set; }
        public string SortedBallString { get; set; }
        public string UnsortedBallString { get; set; }
        public bool IsJackpotWinner { get; set; }
        public string ExtraData { get; set; }
        public string B11 { get; set; }
        public string B12 { get; set; }
        public string B13 { get; set; }
        public string B14 { get; set; }
        public string B15 { get; set; }
        public string B16 { get; set; }
        public string B17 { get; set; }
        public string B18 { get; set; }
        public string B19 { get; set; }
        public string B20 { get; set; }
        public int? Games_Lottery_Bigball_Payout_ID { get; set; }
        public string OrderedOnBehalfOfFullName { get; set; }
        public string OrderedOnBehalfOfCellNumber { get; set; }
        public string B21 { get; set; }
        public string B22 { get; set; }
        public string B23 { get; set; }
        public string B24 { get; set; }
        public string B25 { get; set; }
        public decimal TaxPercentage { get; set; }
        public decimal TaxCharged { get; set; }
        public int BetCount { get; set; }
        public int? OrderBundle_DetailID { get; set; }
        public int? OrderBundleID { get; set; }
        public Guid? OrderBundle_Guid { get; set; }
        public decimal PayoutTaxPercentage { get; set; }
        public decimal PayoutTaxCharged { get; set; }

        public virtual Order Order { get; set; }
        public virtual OrderDetails_Lottery_LotteryProviderDetails OrderDetails_Lottery_LotteryProviderDetails { get; set; }
        public virtual Drawing Drawing { get; set; }
        public virtual OrderBundle_Detail OrderBundle_Detail { get; set; }
    }
}
