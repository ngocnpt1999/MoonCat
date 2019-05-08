using System;
using System.Collections.Generic;
using System.Text;

namespace MoonCat.Model
{
    public class BookingInfo
    {
        public Movie MovieInfo { get; set; }
        public Cinema CinemaInfo { get; set; }
        public MovieShowing TimeInfo { get; set; }
        public List<Seat> ChosenSeats { get; set; }
        public double TotalPrice { get; set; }
    }
}
