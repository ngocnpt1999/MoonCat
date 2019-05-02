using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Collections.ObjectModel;

namespace MoonCat.Model
{
    [Table("Cinema")]
    public class Cinema
    {
        [Column("id")]
        public int ID { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("address")]
        public string Address { get; set; }
        [Column("phone")]
        public string Phone { get; set; }
        [Column("x")]
        public double X { get; set; }
        [Column("y")]
        public double Y { get; set; }
    }
}
