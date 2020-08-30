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
    public partial class ChooseCinemaPage : ContentPage
    {
        private Model.BookingInfo booking;
        private Model.ListChooseCinema listChooseCinema;

        public ChooseCinemaPage(Model.BookingInfo booking)
        {
            InitializeComponent();
            this.booking = booking;
            listChooseCinema = new Model.ListChooseCinema(this.booking.MovieInfo.ID);
            lvChooseCinema.ItemsSource = listChooseCinema.Cinemas;
        }

        private async void LvChooseCinema_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = ((ListView)sender).SelectedItem as Model.Cinema;
            this.booking.CinemaInfo = vm;
            await Navigation.PushAsync(new BeginTimePage(this.booking));
            ((ListView)sender).SelectedItem = null;
        }
    }
}