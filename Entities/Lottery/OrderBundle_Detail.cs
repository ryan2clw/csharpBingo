using System;
namespace SpaBingo.Entities.Lottery
{
    public class OrderBundle_Detail
    {
        public int ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedByStaffID { get; set; }
        public int OrderBundleID { get; set; }
        public long? Games_Lottery_GamesID { get; set; }
        public int? SyndicateID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal? PriceForPayout { get; set; }
        public bool IsBoxed { get; set; }
        //public virtual Games_Lottery_Games Games_Lottery_Games { get; set; }
        public virtual OrderBundle OrderBundle { get; set; }
        //public virtual Syndicate Syndicate { get; set; }
        //public virtual ICollection<OrderDetails_Lottery> OrderDetails_Lottery { get; set; }
        //public virtual ICollection<OrderDetails_Product> OrderDetails_Product { get; set; }
    }
}
