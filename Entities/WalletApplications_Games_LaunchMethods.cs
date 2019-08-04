using System;

namespace SpaBingo.Entities
{
    public class WalletApplications_Games_LaunchMethods
    {
        public int ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public int WalletApplicationID { get; set; }
        public string PaidLaunchURLFormatSandboxed { get; set; }
        public string PaidLaunchURLFormatProduction { get; set; }
        public string FreeplayLaunchURLFormatSandboxed { get; set; }
        public string FreeplayLaunchURLFormatProduction { get; set; }
        public string Configuration { get; set; }
        public bool LaunchFromServer { get; set; }

        public virtual WalletApplication WalletApplication { get; set; }
    }
}