using System;

namespace SpaBingo.Entities.Lottery
{
    public class Transactions_CurrencyConversions
    {
        public long TransactionID { get; set; }
        public decimal Original_Amount { get; set; }
        public string Original_Currency { get; set; }
        public decimal Converted_Amount { get; set; }
        public string Converted_Currency { get; set; }
        public decimal? ConversionRate { get; set; }
        public Guid ReplicationID { get; set; }

        public virtual Transaction Transaction { get; set; }
    }
}