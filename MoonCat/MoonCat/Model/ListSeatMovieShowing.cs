using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using MoonCat.Interface;

namespace MoonCat.Model
{
    public class ListSeatMovieShowing
    {
        public List<Seat> Seats { get; set; }

        public ListSeatMovieShowing(int id_movie_showing)
        {
            var dbConnection = DependencyService.Get<ISQLiteDatabase>().CreateConnection();
            var allSeat = dbConnection.Query<Seat>("SELECT * FROM Seat");
            var seatSelected = dbConnection.Query<SeatSelected>
                ("SELECT * FROM SeatSelected WHERE id_movie_showing = ?",
                new object[1] { id_movie_showing });
            foreach(var it in seatSelected)
            {
                allSeat[it.ID_Seat - 1].Status = 1;
            }
            Seats = new List<Seat>(allSeat);
        }
    }
}
