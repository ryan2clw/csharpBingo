using System;
using System.Collections.Generic;

namespace SpaBingo.Entities
{
    public class OrderBundle
    {
        public int ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedByStaffID { get; set; }
        public int FranchiseID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public virtual Franchise Franchise { get; set; }
        public virtual ICollection<OrderBundle_Detail> OrderBundle_Detail { get; set; }
    }
}