
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace SpaBingo.Entities
{
    public class Card
    {
        public int Id { get; set; }
        public ICollection<Row> Rows { get; set; }
    }
}