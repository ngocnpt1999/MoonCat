using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MoonCat.Model
{
    [Table("MovieShowing")]
    public class MovieShowing
    {
        [Column("id")]
        public int ID { get; set; }
        [Column("id_movie")]
        public int ID_Movie { get; set; }
        [Column("id_cinema")]
        public int ID_Cinema { get; set; }
        [Column("date")]
        public string Date { get; set; }
        [Column("begin")]
        public string Begin { get; set; }
        [Column("price_ticket")]
        public double Price { get; set; }
    }
}
