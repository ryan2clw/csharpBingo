using System;
namespace SpaBingo.Entities.Lottery
{
    public class CustomerAccounts_Exclusions
    {
        public int ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public long CustomerAccountID { get; set; }
        public DateTime ExclusionStartsOn { get; set; }
        public DateTime? ExclusionEndsOn { get; set; }
        public DateTime? ExclusionEndedOn { get; set; }
        public bool IsSelfExcluded { get; set; }
        public string Notes { get; set; }
        public bool IsPermittedToWithdrawFunds { get; set; }
        public bool IsRequiredToWithdrawAllFunds { get; set; }
        public DateTime? CustomerRequestedCancellationOn { get; set; }
        public DateTime? CancellationRequestDeniedOn { get; set; }
        public int? CancellationRequestDeniedByStaffID { get; set; }
        public DateTime? CancellationRequestApprovedOn { get; set; }
        public int? CancellationRequestApprovedByStaffID { get; set; }
        public string CancellationRequestDenialReason { get; set; }
        public int? ExcludedByStaffID { get; set; }
        public virtual CustomerAccount CustomerAccount { get; set; }
    }
}