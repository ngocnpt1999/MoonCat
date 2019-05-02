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
    public partial class MovieComingSoonPage : ContentPage
    {
        private Model.ListMovieComingSoon listMovie = new Model.ListMovieComingSoon();

        public MovieComingSoonPage()
        {
            InitializeComponent();
            lvMovieComingSoon.ItemsSource = listMovie.MoviesComingSoon;
        }

        private async void LvMovieComingSoon_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (((ListView)sender).SelectedItem as Model.Movie == null)
            {
                return;
            }

            await Navigation.PushAsync(new MovieDetailPage(((ListView)sender).SelectedItem as Model.Movie, false));

            ((ListView)sender).SelectedItem = null;
        }
    }
}