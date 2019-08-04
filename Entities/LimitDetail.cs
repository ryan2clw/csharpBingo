using System;


namespace SpaBingo.Entities
{
    public class LimitDetail
    {
        public long ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedByStaffID { get; set; }
        public int LimitID { get; set; }
        public int LimitTypeID { get; set; }
        public string Frequency { get; set; }
        public decimal? Amount { get; set; }
        public virtual Limit Limit { get; set; }
        public virtual LimitType LimitType { get; set; }
    }
}