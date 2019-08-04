using System;

namespace SpaBingo.Entities
{
    public class Customers_Sessions
    {
		public long ID { get; set; }
		public Guid ReplicationID { get; set; }
		public byte[] Timestamp { get; set; }
		public long CustomerID { get; set; }
		public string SessionID { get; set; }
		public string ApplicationID { get; set; }
		public DateTime DateTimeSignedIn { get; set; }
		public DateTime? DateTimeSignedOut { get; set; }
		public DateTime DateTimeLastSeen { get; set; }
		public string SignOutType { get; set; }
		public int? ForcedOutByStaffID { get; set; }
		public string ForcedReason { get; set; }
		public string IPAddress { get; set; }
		public string HostName { get; set; }
		public string BrowserDetails { get; set; }
		public decimal? PreBalance { get; set; }
		public decimal? PostBalance { get; set; }
		public string GeoLookupCountry { get; set; }
		public string GeoLookupAreaName { get; set; }
		public decimal? GeoLookupLatitude { get; set; }
		public decimal? GeoLookupLongitude { get; set; }
		public string GeoLookupIdentifier { get; set; }
        public virtual Tokens_ForCustomers Tokens_ForCustomers { get; set; }
	}
}
