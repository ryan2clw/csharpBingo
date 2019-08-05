using System;
using System.Collections.Generic;

namespace SpaBingo.Entities.Lottery
{
    public class Report_Groups
    {
        public int ID { get; set; }
        public Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? GroupID { get; set; }
        public string CustomRunner { get; set; }
        public bool IsActive { get; set; }
        public bool IsDisplayed { get; set; }
        public string SSRSName { get; set; }
        public int? SortOrder { get; set; }
        public int? TranslationID { get; set; }
        public bool IsGlobalReport { get; set; }

        //public virtual ICollection<Report_ViewableByJobs> Report_ViewableByJobs { get; set; }
        //public virtual ICollection<Report_ViewableInFranchises> Report_ViewableInFranchises { get; set; }
    }
}