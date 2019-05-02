using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MoonCat.Model
{
    [Table("Seat")]
    public class Seat
    {
        [Column("id")]
        public int ID { get; set; }
        [Column("row")]
        public string Row { get; set; }
        [Column("number")]
        public int Number { get; set; }
        public int Status { get; set; } = 0;
    }
}
