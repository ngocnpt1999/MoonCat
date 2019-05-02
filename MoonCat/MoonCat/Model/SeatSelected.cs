using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MoonCat.Model
{
    [Table("SeatSelected")]
    public class SeatSelected
    {
        [Column("id")]
        public int ID { get; set; }
        [Column("id_movie_showing")]
        public int ID_MovieShowing { get; set; }
        [Column("id_seat")]
        public int ID_Seat { get; set; }
    }
}
