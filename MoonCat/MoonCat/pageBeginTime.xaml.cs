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
    public partial class BeginTimePage : ContentPage
    {
        private Model.Movie chosenMovie;
        private Model.Cinema chosenCinema;
        private Model.ListBeginTimeMovieShowing listTime;

        public BeginTimePage(Model.Movie movie, Model.Cinema cinema)
        {
            InitializeComponent();
            this.chosenMovie = movie;
            this.chosenCinema = cinema;
            listTime = new Model.ListBeginTimeMovieShowing(this.chosenMovie.ID, this.chosenCinema.ID);
            lvTime.ItemsSource = listTime.BeginTime;
        }

        private async void LvTime_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = ((ListView)sender).SelectedItem as Model.Timer;
            var dbConnection = DependencyService.Get<ISQLiteDatabase>().CreateConnection();
            var showing = dbConnection.Query<Model.MovieShowing>("SELECT * FROM MovieShowing" +
                " WHERE id_movie = ? AND id_cinema = ? AND date = ? AND begin = ?",
                new object[4]
                {
                    this.chosenMovie.ID,
                    this.chosenCinema.ID,
                    "27/04/2019",
                    vm.Time
                });
            await Navigation.PushAsync(new SeatMovieShowingPage(this.chosenMovie, this.chosenCinema, showing[0]));
            ((ListView)sender).SelectedItem = null;
        }
    }
}