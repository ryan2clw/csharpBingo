using System;

namespace SpaBingo.Entities
{
    public class Customer_Billing_Queue_Detail
    {
        public long ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public long Customer_Billing_QueueID { get; set; }
        public long? CustomerAccountID { get; set; }
        public int? ShareCount { get; set; }
        public decimal Amount { get; set; }
        public bool IsManualPayment { get; set; }
        public long? PeriodID { get; set; }
        public long? PoolID { get; set; }
        public long? SyndicateOrderID { get; set; }
        public long? OrderDetailID { get; set; }
        public decimal? ConversionRate { get; set; }
        public long? PrepTransactionID { get; set; }
        public long? TransactionID { get; set; }
        public DateTime? ProcessedOn { get; set; }
        public string ResponseStatus { get; set; }
        public string ResponseMessage { get; set; }
        public virtual Customer_Billing_Queue Customer_Billing_Queue { get; set; }
        public virtual CustomerAccount CustomerAccount { get; set; }
    }
}