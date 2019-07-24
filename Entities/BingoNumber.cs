using System;
using System.Collections.Generic;

namespace WebApi.Entities
{
    public class BingoNumber
    {
        public int Id { get; set; }
        public string NumValue { get; set; }
        public bool IsPlayed { get; set; }

        public DateTime Updated {get; set; }

    }
}