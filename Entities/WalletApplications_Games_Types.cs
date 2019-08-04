using System.Collections.Generic;

namespace SpaBingo.Entities
{
    public class WalletApplications_Games_Types
    {
        public int ID { get; set; }
        public System.Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string Name { get; set; }

        public virtual ICollection<WalletApplication> WalletApplications { get; set; }

    }
}