using System;
using System.Collections.Generic;

namespace SpaBingo.Entities.Bingo
{
    public class BingoGame
    {
        public int Id { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public ICollection<Ball> CalledBalls { get; set; }
    }
}