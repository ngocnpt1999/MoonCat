using MoonCat.Interface;
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
    public partial class BeginTimePage : ContentPage
    {
        private Model.BookingInfo booking;
        private Model.ListBeginTimeMovieShowing listTime;

        public BeginTimePage(Model.BookingInfo booking)
        {
            InitializeComponent();
            this.booking = booking;
        }

        protected override void OnAppearing()
        {
            listTime = new Model.ListBeginTimeMovieShowing(this.booking.MovieInfo.ID, this.booking.CinemaInfo.ID);
            lvTime.ItemsSource = listTime.BeginTime;
            lvTime.IsVisible = true;
        }

        private async void LvTime_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = ((ListView)sender).SelectedItem as Model.Timer;
            var dbConnection = DependencyService.Get<ISQLiteDatabase>().CreateConnection();
            var showing = dbConnection.Query<Model.MovieShowing>("SELECT * FROM MovieShowing" +
                " WHERE id_movie = ? AND id_cinema = ? AND date = ? AND begin = ?",
                new object[4]
                {
                    this.booking.MovieInfo.ID,
                    this.booking.CinemaInfo.ID,
                    "27/04/2019",
                    vm.Time
                });
            this.booking.TimeInfo = showing[0];
            lvTime.IsVisible = false;
            activityLoading.IsRunning = true;
            activityLoading.IsVisible = true;
            await Navigation.PushAsync(new SeatMovieShowingPage(this.booking));
            activityLoading.IsRunning = false;
            activityLoading.IsVisible = false;
            ((ListView)sender).SelectedItem = null;
        }
    }
}