using System;
using System.Collections.Generic;

namespace SpaBingo.Entities.Lottery
{
    public class Staff
    {
        public int ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public Guid? UserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedByStaffID { get; set; }
        public DateTime? LastChangedOn { get; set; }
        public int? LastChangedByStaffID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FranchiseID { get; set; }
        public bool IsActive { get; set; }
        public string InactiveReason { get; set; }
        public string LanguageID { get; set; }
        public string Address { get; set; }
        public string CellPhone { get; set; }
        public string AlternatePhone { get; set; }
        public string EmailAddress { get; set; }
        public int? LocationID { get; set; }
        public int? ThirdPartyID { get; set; }
        public int? JobID { get; set; }
        public DateTime? LastSignedInOn { get; set; }
        public DateTime? LastSeenOn { get; set; }
        public string LastIPAddress { get; set; }
        public int? LastTerminalIDUsed { get; set; }
        public bool ResetPasswordOnNextSignIn { get; set; }
        public bool? CanMakeCustomerDeposits { get; set; }
        public bool? CanMakeCustomerWithdraws { get; set; }
        public bool IsTOTPRequired { get; set; }
        public string TOTPUserKey { get; set; }
        public string PINHash { get; set; }
        public string PINSalt { get; set; }
        public int ThemePreference { get; set; }
        //public virtual Franchise Franchise { get; set; }
        public virtual ICollection<Staff_Sessions> Staff_Sessions { get; set; }
        public virtual Staff_Jobs Staff_Jobs { get; set; }
        // public virtual ICollection<Staff_AllowedFranchises> Staff_AllowedFranchises { get; set; }
    }
}
