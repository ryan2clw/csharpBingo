using System;
using System.Collections.Generic;
namespace SpaBingo.Entities.Lottery
{
    public class CustomerAccount
    {
        public long ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedByStaffID { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedByStaffID { get; set; }
        public Guid Guid { get; set; }
        public Guid UserID { get; set; }
        public long? CustomerID { get; set; }
        public string Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? EmailAddressVerified { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumberStripped { get; set; }
        public DateTime? PhoneNumberVerified { get; set; }
        public string CellPhone { get; set; }
        public string CellPhoneStripped { get; set; }
        public string PINHash { get; set; }
        public string PINSalt { get; set; }
        public bool IsDocumentationVerified { get; set; }
        public DateTime? DocumentationVerified { get; set; }
        public bool IsExemptFromDocumentVerification { get; set; }
        public string CardID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string Locality { get; set; }
        public string Region { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string Employer { get; set; }
        public bool IsDomestic { get; set; }
        public bool IsTermsExplained { get; set; }
        public DateTime? AddressVerified { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public int? ApprovedByStaffID { get; set; }
        public DateTime? DeniedOn { get; set; }
        public int? DeniedByStaffID { get; set; }
        public string DenialReason { get; set; }
        public int? SystemImposedLimitID { get; set; }
        public int? SelfImposedLimitID { get; set; }
        public bool IsRequiringPasswordUpdate { get; set; }
        public long? TransactionIDOfFirstCustomerDeposit { get; set; }
        public int? AffiliateID { get; set; }
        public bool IsExemptFromLocationChecks { get; set; }
        public bool IsTestCustomer { get; set; }
        public bool IsWalletApplicationTestCustomer { get; set; }
        public DateTime? CellPhoneVerified { get; set; }
        public int? MediaCodeID { get; set; }
        public bool Syndicate_HadFreeSyndicate { get; set; }
        public bool? AddressService_MatchingAddressesFound { get; set; }
        public bool? AddressService_StaffOverrodeFoundAddress { get; set; }
        public bool IsAccountUnderReview { get; set; }
        public string AccountUnderReviewReason { get; set; }
        public string AccountUnderReviewReasonDetails { get; set; }
        public DateTime? AgeVerified { get; set; }
        public DateTime? AgeVerificationOverridden { get; set; }
        public int? AgeVerificationOverriddenStaffID { get; set; }
        public string AffiliateExtraData { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public bool OptIn_Important { get; set; }
        public bool OptIn_Marketing { get; set; }
        public bool IsTOTPRequired { get; set; }
        public string TOTPUserKey { get; set; }
        public string ImportNotes { get; set; }
        public string ImportedIdentifier { get; set; }
        public virtual ICollection<CustomerAccounts_Exclusions> CustomerAccounts_Exclusions { get; set; }
        public virtual ICollection<CustomerBalance> CustomerBalances { get; set; }
        public virtual Limit SelfImposedLimit { get; set; }
        public virtual Limit SystemImposedLimit { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Customer_Billing_Queue_Detail> Customer_Billing_Queue_Detail { get; set; }
        public virtual CustomerAccounts_Syndicates_ExtraData CustomerAccounts_Syndicates_ExtraData { get; set; }
    }
}