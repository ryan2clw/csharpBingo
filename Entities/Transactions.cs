﻿using System;
using System.Collections.Generic;

namespace SpaBingo.Entities
{
    public class Transactions
    {

        public long ID { get; set; }
        public byte[] Timestamp { get; set; }
        public Guid ReplicationID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedByStaffID { get; set; }
        public DateTime AppliesToDateTime { get; set; }
        public decimal? Amount { get; set; }
        public decimal? PreAmount { get; set; }
        public decimal? PostAmount { get; set; }
        public int? OrderSourceID { get; set; }
        public int? GameTypeID { get; set; }
        public int? LocationID { get; set; }
        public int? StaffID { get; set; }
        public int? ThirdPartyID { get; set; }
        public int? TerminalID { get; set; }
        public bool? ForwardedToWallet { get; set; }
        public DateTime? ForwardedSuccessOn { get; set; }
        public int ForwardingFailCount { get; set; }
        public DateTime? ForwardedLastFailedOn { get; set; }
        public string ForwardingIdentifier { get; set; }
        public long? ExternalTransactionID { get; set; }
        public long? CustomerBalanceID { get; set; }
        public bool IsSystemVoid { get; set; }
        public long? RelatedToTransactionID { get; set; }
        public bool IsNeedingReview { get; set; }
        public long? CustomerSessionID { get; set; }
        public int? BankID { get; set; }
        public int? DisbursementCategoryID { get; set; }
        public string ExternalGameID { get; set; }
        public string ExternalSessionID { get; set; }
        public int? WalletApplicationID { get; set; }
        public string ExternalReferenceID { get; set; }
        public bool IsCorrected { get; set; }
        public int? CorrectedByStaffID { get; set; }
        public DateTime? CorrectedOn { get; set; }
        public long? CorrectedTransactionID { get; set; }
        public bool IsCorrection { get; set; }
        public int? CorrectionByStaffID { get; set; }
        public DateTime? CorrectionOn { get; set; }
        public long? CorrectionTransactionID { get; set; }
        public long? StaffSessionID { get; set; }
        public int? PromotionID { get; set; }
        public int? PromotionSubID { get; set; }
        public short? JackpotID { get; set; }
        public string ExternalRoundID { get; set; }
        public int? ReviewedByStaffID { get; set; }
        public DateTime? ReviewedOn { get; set; }
        public long? DrawingID { get; set; }
        public int? LimitID { get; set; }
        public long? OrderDetails_Lottery_ID { get; set; }
        public decimal TaxRate { get; set; }

        public virtual Customer Customers { get; set; }
        public virtual TransactionType TransactionTypes { get; set; }
        public virtual Franchises Franchises { get; set; }
        public virtual Orders Orders { get; set; }
        public virtual Transactions_AdditionalInfo Transactions_AdditionalInfo { get; set; }
        public virtual Transactions_CurrencyConversions Transactions_CurrencyConversions { get; set; }
        public virtual ICollection<Games_ProgressiveJackpots_Queue> Games_ProgressiveJackpots_Queue { get; set; }
    }
}
