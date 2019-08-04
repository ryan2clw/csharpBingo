using System;

namespace SpaBingo.Entities
{
    public class Report_ViewableByJobs
    {
        public int Report_Item_ID { get; set; }
        public int JobID { get; set; }
        public Guid ReplicationID { get; set; }

        public virtual Report_Items Report_Items { get; set; }
        public virtual Staff_Jobs Staff_Jobs { get; set; }
    }
}