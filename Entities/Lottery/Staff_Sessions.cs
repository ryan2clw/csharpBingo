using System;
namespace SpaBingo.Entities.Lottery
{
    public class Staff_Sessions
    {
		public long ID { get; set; }
		public Guid ReplicationID { get; set; }
		public byte[] Timestamp { get; set; }
		public int StaffID { get; set; }
		public DateTime SignedInOn { get; set; }
		public DateTime? SignedOutOn { get; set; }
		public DateTime DateTimeLastSeen { get; set; }
		public int TerminalTypeID { get; set; }
		public string IPAddress { get; set; }
		public string HostName { get; set; }
		public string BrowserDetails { get; set; }
		public string SignOutType { get; set; }
		public int? ForcedOutByStaffID { get; set; }
		public string ForcedReason { get; set; }
		public string SessionID { get; set; }
		public string GeoLookupCountry { get; set; }
		public string GeoLookupAreaName { get; set; }
		public decimal? GeoLookupLatitude { get; set; }
		public decimal? GeoLookupLongitude { get; set; }
		public string GeoLookupIdentifier { get; set; }
		public int? TerminalID { get; set; }
		public virtual Staff Staff { get; set; }
	}
}