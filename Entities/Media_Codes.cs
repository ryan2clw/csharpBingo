using System;
using System.Collections.Generic;

namespace SpaBingo.Entities
{
    public class Media_Codes
    {

            public int ID { get; set; }
            public Guid ReplicationID { get; set; }
            public byte[] Timestamp { get; set; }
            public DateTime CreatedOn { get; set; }
            public int? CreatedByStaffID { get; set; }
            public DateTime? ChangedOn { get; set; }
            public int? ChangedByStaffID { get; set; }
            public string MediaCode { get; set; }
            public bool IsActive { get; set; }
            public string PartnerName { get; set; }
            public int FranchiseID { get; set; }
            public string MediaTitle { get; set; }
            public string TeaserProduct { get; set; }
            public string Circulation { get; set; }
            public DateTime? PublicationDate { get; set; }
            public string Version { get; set; }
            public string Selection { get; set; }
            public decimal? PrintCosts { get; set; }
            public decimal? CallCenterCosts { get; set; }
            public decimal? MediaCosts { get; set; }
            public decimal? FreeLineCosts { get; set; }
            public int? MediaCodeGroupID { get; set; }

            public virtual ICollection<Syndicate_MediaCodes> Syndicate_MediaCodes { get; set; }
            public virtual Franchise Franchise { get; set; }
            public virtual ICollection<CustomerAccounts_Syndicates_ExtraData> CustomerAccounts_Syndicates_ExtraData { get; set; }
        }
    }
