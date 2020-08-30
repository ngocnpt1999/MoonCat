using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MoonCat.Model
{
    [Table("SeatSelected")]
    public class SeatSelected : BaseModel
    {
        private int id;
        private int id_movieshowing;
        private int id_seat;

        [Column("id")]
        public int ID
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }
        [Column("id_movie_showing")]
        public int ID_MovieShowing
        {
            get => id_movieshowing;
            set
            {
                id_movieshowing = value;
                OnPropertyChanged();
            }
        }
        [Column("id_seat")]
        public int ID_Seat
        {
            get => id_seat;
            set
            {
                id_seat = value;
                OnPropertyChanged();
            }
        }
    }
}