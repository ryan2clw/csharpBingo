using System.Collections.Generic;

namespace WebApi.Entities
{
    public class Ball
    {
        public int Id { get; set; }
        public string NumValue { get; set; }
        public virtual ICollection<BallMatch> BallMatches { get; set; }
    }
}