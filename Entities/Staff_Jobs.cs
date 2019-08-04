using System;
namespace SpaBingo.Entities
{
    public class Staff_Jobs
    {
		public int ID { get; set; }
		public Guid ReplicationID { get; set; }
		public byte[] Timestamp { get; set; }
		public DateTime CreatedOn { get; set; }
		public int? CreatedByStaffID { get; set; }
		public DateTime? LastChangedOn { get; set; }
		public int? LastChangedByStaffID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool ThirdPartyJob { get; set; }

			//public virtual ICollection<Staff_Job_TransactionTypes> Staff_Job_TransactionTypes { get; set; }
			//public virtual ICollection<aspnet_Roles> aspnet_Roles { get; set; }
			//public virtual ICollection<Staff> Staffs { get; set; }
			//public virtual ICollection<Report_ViewableByJobs> Report_ViewableByJobs { get; set; }
    }
}
