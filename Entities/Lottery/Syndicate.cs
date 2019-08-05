using System;
using System.Collections.Generic;

namespace SpaBingo.Entities.Lottery
{
    public class Syndicate
    {

        public int ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedByStaffID { get; set; }
        public DateTime? ChangedOn { get; set; }
        public int? ChangedByStaffID { get; set; }
        public int FranchiseID { get; set; }
        public string Name { get; set; }
        public bool RequiresChoosingNumbers { get; set; }
        public bool RequiresMerchantShare { get; set; }
        public bool IsActive { get; set; }
        public bool IsClosed { get; set; }
        public bool IsFree { get; set; }
        public bool ShareBuysAllGames { get; set; }
        public decimal? CostPerShare { get; set; }
        public bool PerDrawingPeriods { get; set; }
        public string ImageData { get; set; }
        public string ImageMimeType { get; set; }
        public bool IsPromo { get; set; }

        //public virtual Franchise Franchise { get; set; }
        public virtual ICollection<Syndicate_Games_Link> Syndicate_Games_Link { get; set; }
        public virtual ICollection<Syndicate_MediaCodes> Syndicate_MediaCodes { get; set; }
        //public virtual ICollection<Syndicate_Promo_Link> Syndicate_Promo_Link { get; set; }
        public virtual ICollection<OrderBundle_Detail> OrderBundle_Detail { get; set; }
        public virtual ICollection<OrderDetails_Product> OrderDetails_Product { get; set; }
    }
}