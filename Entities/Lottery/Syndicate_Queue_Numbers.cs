namespace SpaBingo.Entities.Lottery
{
    public class Syndicate_Queue_Numbers
    {
        public long ID { get; set; }
        public System.Guid ReplicationID { get; set; }
        public byte[] Timestamp { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public long Syndicate_Queue_DetailsID { get; set; }
        public string B1 { get; set; }
        public string B2 { get; set; }
        public string B3 { get; set; }
        public string B4 { get; set; }
        public string B5 { get; set; }
        public string B6 { get; set; }
        public string B7 { get; set; }
        public string B8 { get; set; }
        public string B9 { get; set; }
        public string B10 { get; set; }
        public string B11 { get; set; }
        public string B12 { get; set; }
        public string B13 { get; set; }
        public string B14 { get; set; }
        public string B15 { get; set; }
        public string B16 { get; set; }
        public string B17 { get; set; }
        public string B18 { get; set; }
        public string B19 { get; set; }
        public string B20 { get; set; }
        public string SortedBallString { get; set; }
        public virtual Syndicate_Queue_Details Syndicate_Queue_Details { get; set; }
    }
}
