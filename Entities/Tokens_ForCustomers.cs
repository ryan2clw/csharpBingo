using System;

namespace SpaBingo.Entities
{
    public class Tokens_ForCustomers
    {
        public long TokenID { get; set; }
        public long CustomerID { get; set; }
        public int WalletApplicationID { get; set; }
        public long? CustomerSessionID { get; set; }
        public Guid ReplicationID { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Customers_Sessions Customers_Sessions { get; set; }
        public virtual Token Token { get; set; }
        public virtual WalletApplication WalletApplication { get; set; }
    }
}
