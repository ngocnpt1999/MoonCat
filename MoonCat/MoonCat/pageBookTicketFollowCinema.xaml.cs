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
    public partial class BookTicketFollowCinemaPage : ContentPage
    {
        private Model.ListAllCinema listAllCinema = new Model.ListAllCinema();

        public BookTicketFollowCinemaPage()
        {
            InitializeComponent();
            lvCinema.ItemsSource = this.listAllCinema.Cinemas;
        }

        private async void LvCinema_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = ((ListView)sender).SelectedItem as Model.Cinema;
            Model.BookingInfo booking = new Model.BookingInfo() { CinemaInfo = vm };
            await Navigation.PushAsync(new MovieShowingAtCinemaPage(booking));
            ((ListView)sender).SelectedItem = null;
        }
    }
}