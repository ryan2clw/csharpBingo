using System;
using System.Collections.Generic;

namespace SpaBingo.Entities.Lottery
{
    public class WalletApplication
    {
        public int ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Name { get; set; }
        public Guid GUID { get; set; }
        public bool IsActive { get; set; }
        public bool IsInternal { get; set; }
        public string APIUsername { get; set; }
        public string APIPassword { get; set; }
        public int Tokens_AllowedReuseCount { get; set; }
        public int Tokens_AllowedNumberKeptBesidesCurrent { get; set; }
        public int? Tokens_ExpireAfterSeconds { get; set; }
        public string AllowedHosts { get; set; }
        public string URLName { get; set; }
        public int? WalletApplicationGameTypeID { get; set; }
        public string DisplayName { get; set; }
        public string InactiveReason { get; set; }
        public string APIType { get; set; }
        public string AdminAllowedHosts { get; set; }
        public decimal? VendorPercentage { get; set; }
        public string InternalNotes { get; set; }
        public string APISecretHash { get; set; }
        public short DaysToKeepAPIRecordsFor { get; set; }
        public bool IsDisplayed { get; set; }
        public virtual WalletApplications_Games_Types WalletApplications_Games_Types { get; set; }
        public virtual ICollection<Tokens_ForCustomers> Tokens_ForCustomers { get; set; }
        public virtual ICollection<WalletApplications_Games_LaunchMethods> WalletApplications_Games_LaunchMethods { get; set; }
    }
}