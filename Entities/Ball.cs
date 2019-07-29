using System;
using System.Collections.Generic;

namespace WebApi.Entities
{
    public class Ball
    {
        public int Id { get; set; }
        public string NumValue { get; set; }
        public bool IsPlayed { get; set; }
        public DateTime Updated { get; set; }
        public virtual ICollection<BallMatch> BallMatch { get; set; }
    }
}