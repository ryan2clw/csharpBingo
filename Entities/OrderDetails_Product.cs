using System;

namespace SpaBingo.Entities
{
    public class OrderDetails_Product
    {
        public long ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? LastChangedOn { get; set; }
        public long OrderID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public bool IsComped { get; set; }
        public string ReasonComped { get; set; }
        public string Description { get; set; }
        public int? SyndicateID { get; set; }
        public long? TransactionID { get; set; }
        public int? OrderBundleID { get; set; }
        public int? OrderBundle_DetailID { get; set; }
        public Guid? OrderBundle_Guid { get; set; }

        public virtual OrderBundle_Detail OrderBundle_Detail { get; set; }
        public virtual Order Order { get; set; }
        public virtual Syndicate Syndicate { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
