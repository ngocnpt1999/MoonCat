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
        private Model.BookingInfo booking;

        public ConfirmPayPage(Model.BookingInfo booking)
        {
            InitializeComponent();
            this.booking = booking;
            load();
        }

        private void load()
        {
            slMovieInfo.BindingContext = this.booking.MovieInfo;
            slCinemaInfo.BindingContext = this.booking.CinemaInfo;
            slTime.BindingContext = this.booking.TimeInfo;
            lbTotal.Text = String.Format("Thành tiền: {0:c}", this.booking.TotalPrice);
            foreach (var it in this.booking.ChosenSeats)
            {
                lbSeat.Text = lbSeat.Text + it.Row + it.Number + " ";
            }
        }

        private void Close_Clicked(object sender, EventArgs e)
        {
            var existingPage = Navigation.NavigationStack.ToList();
            existingPage.RemoveAt(0);
            foreach(var it in existingPage)
            {
                Navigation.RemovePage(it);
            }
        }

        private async void BtnConfirm_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MethodPaymentPage());
        }
    }
}