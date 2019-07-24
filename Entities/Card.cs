using System.Collections.Generic;

namespace WebApi.Entities
{
    public class Card
    {
        public int Id { get; set; }
        public ICollection<Row> Rows { get; set; }
    }
}