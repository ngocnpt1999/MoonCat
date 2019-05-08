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
    public partial class MovieDetailPage : ContentPage
    {
        private Model.Movie chosenMovie;
        public MovieDetailPage(Model.Movie movie, bool active)
        {
            InitializeComponent();
            this.chosenMovie = movie;
            BindingContext = chosenMovie;
            btnBookTicket.IsVisible = active;
        }

        private async void BtnBookTicket_Clicked(object sender, EventArgs e)
        {
            Model.BookingInfo booking = new Model.BookingInfo() { MovieInfo = this.chosenMovie };
            await Navigation.PushAsync(new ChooseCinemaPage(booking));
        }

        private async void WatchTrailer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TrailerWebViewPage(this.chosenMovie.TrailerURL));
        }
    }
}