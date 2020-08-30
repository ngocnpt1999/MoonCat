using System;
using System.Collections.Generic;
using System.Text;

namespace MoonCat.Model
{
    public class BookingInfo : BaseModel
    {
        private Movie movieInfo;
        private Cinema cinemaInfo;
        private MovieShowing timeInfo;
        private List<Seat> chosenSeats;
        private double totalPrice;

        public Movie MovieInfo
        {
            get => movieInfo;
            set
            {
                movieInfo = value;
                OnPropertyChanged();
            }
        }
        public Cinema CinemaInfo
        {
            get => cinemaInfo;
            set
            {
                cinemaInfo = value;
                OnPropertyChanged();
            }
        }
        public MovieShowing TimeInfo
        {
            get => timeInfo;
            set
            {
                timeInfo = value;
                OnPropertyChanged();
            }
        }
        public List<Seat> ChosenSeats
        {
            get => chosenSeats;
            set
            {
                chosenSeats = value;
                OnPropertyChanged();
            }
        }
        public double TotalPrice
        {
            get => totalPrice;
            set
            {
                totalPrice = value;
                OnPropertyChanged();
            }
        }
    }
}