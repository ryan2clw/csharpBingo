using System;

namespace SpaBingo.Entities
{
    public class OrderDetails_Lottery_LotteryProviderDetails
    {
        public long OrderDetails_Lottery_ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public int Games_Lottery_LotteryProviderGameType_ID { get; set; }
        public string RequestForIDStatus { get; set; }
        public string RequestForIDMessage { get; set; }
        public DateTime? RequestForIDSentOn { get; set; }
        public int? RequestForIDRetryCount { get; set; }
        public DateTime? ResponseForIDReceivedOn { get; set; }
        public string LottoProviderTicketID { get; set; }
        public string RequestForDetailsStatus { get; set; }
        public string RequestForDetailsMessage { get; set; }
        public DateTime? RequestForDetailsSentOn { get; set; }
        public int? RequestForDetailsRetryCount { get; set; }
        public DateTime? ResponseForDetailsReceivedOn { get; set; }
        public string TicketDetails { get; set; }
        public string RequestForIDRawRequest { get; set; }
        public string RequestForIDRawResponse { get; set; }
        public string RequestForDetailsRawRequest { get; set; }
        public string RequestForDetailsRawResponse { get; set; }
        public string ImageURL { get; set; }
        public DateTime? TicketDrawingDate { get; set; }
        public string RaffleNumber { get; set; }
        public string SerialNumber { get; set; }
        public string RequestForPrizeStatus { get; set; }
        public DateTime? RequestForPrizeSentOn { get; set; }
        public int? RequestForPrizeRetryCount { get; set; }
        public decimal? PrizeAmount { get; set; }
        public string ExtraLottoProviderTicketID { get; set; }
        public string RequestForPrizeMessage { get; set; }
        public DateTime? ResponseForPrizeReceivedOn { get; set; }
        public string RequestForPrizeRawRequest { get; set; }
        public string RequestForPrizeRawResponse { get; set; }
        public bool IsExtraTicket { get; set; }
        public long? ExtraLottoProviderTicket_OrderDetails_Lottery_ID { get; set; }
        public string TicketCurrency { get; set; }

        public virtual OrderDetails_Lottery OrderDetails_Lottery { get; set; }
        public virtual Games_Lottery_LotteryProviderGameTypes Games_Lottery_LotteryProviderGameTypes { get; set; }
    }
}
