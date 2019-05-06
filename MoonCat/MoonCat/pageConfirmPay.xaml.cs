using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoonCat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfirmPayPage : ContentPage
    {
        private Model.Movie movieInfo;
        private Model.Cinema cinemaInfo;
        private Model.MovieShowing chosenTime;
        private List<Model.Seat> chosenSeats;
        private double total;

        public ConfirmPayPage(Model.Movie movie, Model.Cinema cinema,
                              Model.MovieShowing time, List<Model.Seat> chosenSeats)
        {
            InitializeComponent();
            this.movieInfo = movie;
            this.cinemaInfo = cinema;
            this.chosenTime = time;
            this.chosenSeats = chosenSeats;
            load();
        }

        private void load()
        {
            this.total = this.chosenSeats.Count * this.chosenTime.Price;
            slMovieInfo.BindingContext = this.movieInfo;
            slCinemaInfo.BindingContext = this.cinemaInfo;
            slTime.BindingContext = this.chosenTime;
            lbTotal.Text = String.Format("Thành tiền: {0:c}", this.total);
            foreach (var it in chosenSeats)
            {
                lbSeat.Text = lbSeat.Text + it.Row + it.Number + " ";
            }
        }
    }
}