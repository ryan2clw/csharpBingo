using System;
using System.Collections.Generic;
namespace SpaBingo.Entities
{
    public class Customer
    {
        public int ID { get; set; }
        public byte[] Timestamp { get; set; }
        public Guid ReplicationID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ExternalCustomerID { get; set; }
        public int FranchiseID { get; set; }
        public bool IsActive { get; set; }
        public string InactiveReason { get; set; }
        public int? MarkedInactiveByStaffID { get; set; }
        public string Alias { get; set; }
        public DateTime? LastSeenOn { get; set; }
        public bool? CanMakeDeposits { get; set; }
        public bool? CanMakeWithdraws { get; set; }
        public string LastSeenIPAddress { get; set; }
        public string LastSeenHostName { get; set; }
        public int? AssignedStaffID { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual Franchise Franchise { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<CustomerAccount> CustomerAccounts { get; set; }
        public virtual ICollection<Tokens_ForCustomers> Tokens_ForCustomers { get; set; }
    }
}