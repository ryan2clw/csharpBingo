using System;
using System.Collections.Generic;

namespace SpaBingo.Entities
{
    public class TransactionType
    {
        public int ID { get; set; }
        public byte[] Timestamp { get; set; }
        public Guid ReplicationID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Name { get; set; }
        public string APIName { get; set; }
        public string DCCustomer { get; set; }
        public string DCStaff { get; set; }
        public string DCThirdParty { get; set; }
        public string InternalNotes { get; set; }
        public int? TranslationID { get; set; }
        public int? TransactionTypeGroupID { get; set; }
        public bool IsCorrectable { get; set; }
        public bool RequiresFollowUp { get; set; }
        public string CustomerDisplayName { get; set; }
        public bool IsShownToCustomers { get; set; }
        public bool IsShownToStaff { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Staff_Job_TransactionTypes> Staff_Job_TransactionTypes { get; set; }
    }
}
