using System;
using System.Collections.Generic;

namespace SpaBingo.Entities.Lottery
{
    public class Games_Lottery_LotteryProviders
    { 
        public int ID { get; set; }
        public string Name { get; set; }
        public string APIEndpointURL { get; set; }
        public bool IsActive { get; set; }
        public string APIUsername { get; set; }
        public string APIPassword { get; set; }
        public string InternalNotes { get; set; }
        public string InstanceAlias { get; set; }
        public Guid ReplicationID { get; set; }
        public string APICallbackURL { get; set; }

        public virtual ICollection<Games_Lottery_LotteryProviderGameTypes> Games_Lottery_LotteryProviderGameTypes { get; set; }
    }
}
