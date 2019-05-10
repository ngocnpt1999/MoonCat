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
        private Model.BookingInfo booking;

        public MovieDetailPage(Model.BookingInfo booking, bool active)
        {
            InitializeComponent();
            this.booking = booking;
            BindingContext = this.booking.MovieInfo;
            btnBookTicket.IsVisible = active;
            if (this.booking.CinemaInfo == null)
            {
                btnBookTicket.Clicked += BtnBookTicket_Clicked;
            }
            else
            {
                btnBookTicket.Clicked += BtnBookTicket_Clicked_1;
            }
        }

        private async void BtnBookTicket_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BeginTimePage(this.booking));
        }

        private async void BtnBookTicket_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChooseCinemaPage(this.booking));
        }

        private async void WatchTrailer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TrailerWebViewPage(this.booking.MovieInfo.TrailerURL));
        }
    }
}