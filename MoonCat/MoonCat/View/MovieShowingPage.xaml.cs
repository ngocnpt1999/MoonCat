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
    public partial class MovieShowingPage : ContentPage
    {
        private Model.ListMovieShowing listMovie = new Model.ListMovieShowing();

        public MovieShowingPage()
        {
            InitializeComponent();
            lvMovieShowing.ItemsSource = listMovie.MoviesShowing;
        }

        private async void LvMovieShowing_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (((ListView)sender).SelectedItem as Model.Movie == null)
            {
                return;
            }

            var vm = ((ListView)sender).SelectedItem as Model.Movie;
            Model.BookingInfo booking = new Model.BookingInfo() { MovieInfo = vm };
            Page page = new MovieDetailPage(booking, true);
            page.Title = vm.Name;
            await Navigation.PushAsync(page);

            ((ListView)sender).SelectedItem = null;
        }
    }
}