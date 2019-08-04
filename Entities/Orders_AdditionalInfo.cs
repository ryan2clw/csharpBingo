using System;

namespace SpaBingo.Entities
{
    public class Orders_AdditionalInfo
    {
        public long OrderID { get; set; }
        public string WinnerName { get; set; }
        public string WinnerPhone { get; set; }
        public string WinnerEmail { get; set; }
        public string WinnerNote { get; set; }
        public Guid ReplicationID { get; set; }
        public virtual Order Order { get; set; }
    }
}
