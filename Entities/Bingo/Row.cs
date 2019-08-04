using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace SpaBingo.Entities.Bingo
{
    [DataContract]
    public class Row
    {
        public int Id { get; set; }
        [DataMember]
        public string B { get; set; }
        [DataMember]
        public string I { get; set; }
        [DataMember]
        public string N { get; set; }
        [DataMember]
        public string G { get; set; }
        [DataMember]
        public string O { get; set; }

        public int CardID { get; set; }
    }
}