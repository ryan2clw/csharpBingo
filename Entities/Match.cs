using System.Collections.Generic;

namespace WebApi.Entities
{
    public class Match
    {
        public int Id { get; set; }
        public string B { get; set; }
        public string I { get; set; }
        public string N { get; set; }
        public string G { get; set; }
        public string O { get; set; }
        public int CardID { get; set; }
        public virtual ICollection<BallMatch> BallMatch { get; set; }
    }
}