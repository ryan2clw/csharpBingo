using System;
using System.Collections.Generic;

namespace SpaBingo.Entities.Lottery
{
    public class Drawings
    {

        public long ID { get; set; }
        public byte[] Timestamp { get; set; }
        public Guid ReplicationID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CustomLookupKey { get; set; }
        public DateTime DrawingDT { get; set; }
        public DateTime? CloseDT { get; set; }
        public bool IsActive { get; set; }
        public bool IsPosted { get; set; }
        public DateTime? PostedAtDT { get; set; }
        public int? CreatedByStaffID { get; set; }
        public int? PostedByStaffID { get; set; }
        public int? UnpostedByStaffID { get; set; }
        public DateTime? UnpostedAtDT { get; set; }
        public int? TimezoneID { get; set; }
        public bool? WasAutoPosted { get; set; }
        public bool CanBeAutoPosted { get; set; }
        public string AutoPostingInactiveReason { get; set; }
        public DateTime? StartDT { get; set; }
        public DateTime OriginalDrawsOn { get; set; }
        public string WeekAndYearCode { get; set; }
        public string TimezoneIANA { get; set; }

        //public virtual Franchises Franchises { get; set; }
        public virtual GameType GameTypes { get; set; }
        public virtual ICollection<OrderDetails_Lottery> OrderDetails_Lottery { get; set; }
        //public virtual Games_Lottery_Drawings_ExtraInfo Games_Lottery_Drawings_ExtraInfo { get; set; }
        public virtual ICollection<Games_Lottery_Drawings> Games_Lottery_Drawings { get; set; }
    }
}