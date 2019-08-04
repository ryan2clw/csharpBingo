using System;
using System.Collections.Generic;

namespace SpaBingo.Entities
{
    public class CustomerBalanceType
    {
        public int ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedByStaffID { get; set; }
        public string Name { get; set; }
        public decimal? MaxLimitAmount { get; set; }
        public bool IsDisplayed { get; set; }
        public string Alias { get; set; }
        public int? DisplayOrder { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Promotions_EventBonusing_Events> Promotions_EventBonusing_Events { get; set; }
        public virtual ICollection<CustomerBalance> CustomerBalances { get; set; }
    }
}