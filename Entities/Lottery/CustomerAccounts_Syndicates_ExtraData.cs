using System;

namespace SpaBingo.Entities.Lottery
{
    public class CustomerAccounts_Syndicates_ExtraData
    {
        public long CustomerAccountID { get; set; }
        public bool HasEverHadFreeShare { get; set; }
        public bool HasEverHadPaidShare { get; set; }
        public bool CurrentlyHasFreeShare { get; set; }
        public bool CurrentlyHasPaidShare { get; set; }
        public bool IsCurrentlyPaymentMethodSuccess { get; set; }
        public bool IsCurrentlyPaymentMethodFailure { get; set; }
        public Guid ReplicationID { get; set; }
        public bool CustomerNeedsClosingLetter { get; set; }
        public bool HasHadPromoSyndicate { get; set; }
        public bool HasPaymentProcessorSwitchedToBACS { get; set; }
        public int? MediaCodeUpdateID { get; set; }
        public virtual CustomerAccount CustomerAccount { get; set; }
        public virtual Media_Codes Media_Codes { get; set; }
    }
}
