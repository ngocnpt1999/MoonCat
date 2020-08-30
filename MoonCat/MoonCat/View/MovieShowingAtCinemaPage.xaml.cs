using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoonCat.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieShowingAtCinemaPage : ContentPage
    {
        private Model.BookingInfo booking;
        private Model.ListMovieShowing listMovie;

        public MovieShowingAtCinemaPage(Model.BookingInfo booking)
        {
            InitializeComponent();
            this.booking = booking;
            listMovie = new Model.ListMovieShowing(this.booking.CinemaInfo.ID);
            lvMovieShowing.ItemsSource = this.listMovie.MoviesShowing;
        }

        private async void LvMovieShowing_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = ((ListView)sender).SelectedItem as Model.Movie;
            this.booking.MovieInfo = vm;
            Page page = new MovieDetailPage(booking, true);
            page.Title = vm.Name;
            await Navigation.PushAsync(page);
            ((ListView)sender).SelectedItem = null;
        }
    }
}