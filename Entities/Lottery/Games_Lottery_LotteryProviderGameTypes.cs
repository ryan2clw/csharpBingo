using System;
using System.Collections.Generic;

namespace SpaBingo.Entities.Lottery
{
    public class Games_Lottery_LotteryProviderGameTypes
    {

        public int ID { get; set; }
        public int Games_Lottery_LotteryProviderID { get; set; }
        public string ProviderName { get; set; }
        public string ProviderID { get; set; }
        public int Games_Lottery_ExternalLottery_ID { get; set; }
        public byte? SupportedPrizeCoverageCount { get; set; }
        public Guid ReplicationID { get; set; }
        public bool IsActive { get; set; }

        public virtual Games_Lottery_LotteryProviders Games_Lottery_LotteryProviders { get; set; }
        public virtual ICollection<OrderDetails_Lottery_LotteryProviderDetails> OrderDetails_Lottery_LotteryProviderDetails { get; set; }
        public virtual ICollection<Games_Lottery_GameTypes> Games_Lottery_GameTypes { get; set; }
    }
}
