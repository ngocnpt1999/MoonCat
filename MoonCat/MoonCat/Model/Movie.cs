using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MoonCat.Model
{
    [Table("Movie")]
    public class Movie
    {
        [Column("id")]
        public int ID { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("image")]
        public string Image { get; set; }
        [Column("producer")]
        public string Producer { get; set; }
        [Column("director")]
        public string Director { get; set; }
        [Column("premiere")]
        public string Premiere { get; set; }
        [Column("duration")]
        public string Duration { get; set; }
        [Column("detail")]
        public string Detail { get; set; }
        [Column("trailer")]
        public string TrailerURL { get; set; }
    }
}
