using System.Collections.Generic;

namespace SpaBingo.Entities
{
    // Originally rows and matches were 1 to 1, bad idea
    // Rows describe actual rows on a card and matches describe groups of numbers that play together
    // When a ball is blown, the ball match table is auto populated based on the many-to-many relationship
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