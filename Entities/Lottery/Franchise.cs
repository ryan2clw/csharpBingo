using System;
using System.Collections.Generic;

namespace SpaBingo.Entities.Lottery
{
    public class Franchise
    {
        public int ID { get; set; }
        public byte[] Timestamp { get; set; }
        public Guid ReplicationID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string Notes { get; set; }
        public bool IsIncludedInReports { get; set; }
        public string WalletType { get; set; }
        public string TimeZone { get; set; }
        public string TimeZoneOffset { get; set; }
        public string TimeZoneName { get; set; }
        public string DefaultLanguage { get; set; }
        public Guid? ASPCustomerApplicationID { get; set; }
        public string Wallet_APIURL { get; set; }
        public string Wallet_APIAuthentication { get; set; }
        public string Wallet_Currency { get; set; }
        public string TicketHeader { get; set; }
        public string TicketFooter { get; set; }
        public string Denominations { get; set; }
        public bool AllowFractionalBets { get; set; }
        public string CurrencyCulture { get; set; }
        public string TicketLogo { get; set; }
        public int? DepositWithdrawFranchiseID { get; set; }
        public bool CanMakeCustomerDeposits { get; set; }
        public bool CanMakeCustomerWithdraws { get; set; }
        public bool IsSwipeRequired { get; set; }
        public string ATMCardParsingRegex { get; set; }
        public int? OrderValidDays { get; set; }
        public int? SystemLimitID { get; set; }
        public bool SysopOnly { get; set; }
        public bool Gaming_UsesCashBalance { get; set; }
        public bool Gaming_UsesBonusBalance { get; set; }
        public bool Gaming_UsesBonusBalanceBeforeCashBalance { get; set; }
        public decimal? Payouts_DailyPayoutMaximumThreshold { get; set; }
        public string FilterCustomersByCountry { get; set; }
        public string InactiveReason { get; set; }
        public bool UseDaylightSavingsTime { get; set; }
        public string TimezoneIANA { get; set; }
        public bool IsPayoutByOrderDetail { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Games_Lottery_BallLimits> Games_Lottery_BallLimits { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Staff_AllowedFranchises> Staff_AllowedFranchises { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual Franchise_ConfigurationSettings_Lottery Franchise_ConfigurationSettings_Lottery { get; set; }
        public virtual ICollection<Drawing> Drawings { get; set; }
        public virtual ICollection<Syndicate> Syndicates { get; set; }
        public virtual ICollection<Media_Codes> Media_Codes { get; set; }
        public virtual ICollection<Syndicate_Games> Syndicate_Games { get; set; }
        public virtual Limit Limit { get; set; }
        public virtual ICollection<Staff> Staffs { get; set; }
        public virtual ICollection<Games_Lottery_Games> Games_Lottery_Games { get; set; }
        public virtual ICollection<Report_ViewableInFranchises> Report_ViewableInFranchises { get; set; }
        public virtual ICollection<Promotion_Franchises> Promotion_Franchises { get; set; }
        public virtual ICollection<Media_Code_Groups> Media_Code_Groups { get; set; }
        public virtual ICollection<Syndicate_Promo_Link> Syndicate_Promo_Link { get; set; }
        public virtual ICollection<OrderBundle> OrderBundles { get; set; }
        public virtual ICollection<FormFields_ConfigurationSettings> FormFields_ConfigurationSettings { get; set; }
    }
}
