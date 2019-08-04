using System;
namespace SpaBingo.Entities
{
    public class Staff_Job_TransactionTypes
    {
        public int ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedByStaffID { get; set; }
        public int Staff_Job_ID { get; set; }
        public int TransactionTypeID { get; set; }
        public bool CanReview { get; set; }
        public virtual Staff_Jobs Staff_Jobs { get; set; }
        public virtual TransactionType TransactionType { get; set; }
    }
}