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

        public ConfirmPayPage(int id_movieShowing, List<Model.Seat> chosenSeats)
        {
            InitializeComponent();
            this.chosenSeats = chosenSeats;
            load(id_movieShowing);
        }

        private void load(int id_movieShowing)
        {
            var dbConnection = DependencyService.Get<ISQLiteDatabase>().CreateConnection();
            var showing = dbConnection.Query<Model.MovieShowing>("SELECT * FROM MovieShowing WHERE id = ?",
                                                                 new object[1] { id_movieShowing });
            this.chosenTime = showing[0];
            var movie = dbConnection.Query<Model.Movie>("SELECT * FROM Movie WHERE id = ?",
                                                        new object[1] { this.chosenTime.ID_Movie });
            this.movieInfo = movie[0];
            var cinema = dbConnection.Query<Model.Cinema>("SELECT * FROM Cinema WHERE id = ?",
                                                        new object[1] { this.chosenTime.ID_Cinema });
            this.cinemaInfo = cinema[0];
            this.total = this.chosenSeats.Count * this.chosenTime.Price;
            //
            //
            slMovieInfo.BindingContext = this.movieInfo;
            slCinemaInfo.BindingContext = this.cinemaInfo;
            slTime.BindingContext = this.chosenTime;
            lbTotal.Text = String.Format("Thành tiền: {0:c}", this.total);
            //
            //
            foreach (var it in chosenSeats)
            {
                lbSeat.Text = lbSeat.Text + it.Row + it.Number + " ";
            }
        }
    }
}