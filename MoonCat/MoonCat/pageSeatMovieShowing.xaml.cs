using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoonCat
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SeatMovieShowingPage : ContentPage
	{
        private Model.Movie chosenMovie;
        private Model.Cinema chosenCinema;
        private Model.MovieShowing time;
        private Model.ListSeatMovieShowing listSeats;
        private List<Model.Seat> chosenSeats = new List<Model.Seat>();

        public SeatMovieShowingPage(Model.Movie movie, Model.Cinema cinema, Model.MovieShowing time)
		{
            InitializeComponent();
            this.Appearing += SeatMovieShowingPage_Appearing;
            this.chosenMovie = movie;
            this.chosenCinema = cinema;
            this.time = time;
		}

        private void loadSeats()
        {
            listSeats = new Model.ListSeatMovieShowing(this.time.ID);
            int column = 0;
            int row = 0;
            foreach (var it in listSeats.Seats)
            {
                Button button = new Button()
                {
                    Text = it.Row + it.Number,
                    HeightRequest = 70,
                    WidthRequest = 70,
                    BindingContext = it,
                    FontAttributes = FontAttributes.Bold
                };
                if (it.Status == 0)
                {
                    button.BackgroundColor = Color.Yellow;
                }
                else
                {
                    button.BackgroundColor = Color.Red;
                    button.IsEnabled = false;
                }
                button.Clicked += Button_Clicked;
                grid.Children.Add(button, column, row);
                column++;
                if (column == 5)
                {
                    row++;
                    column = 0;
                }
            }
        }

        private void SeatMovieShowingPage_Appearing(object sender, EventArgs e)
        {
            chosenSeats = new List<Model.Seat>();
            loadSeats();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if((sender as Button).BackgroundColor == Color.Yellow)
            {
                (sender as Button).BackgroundColor = Color.CadetBlue;
                chosenSeats.Add((((Button)sender).BindingContext) as Model.Seat);
            }
            else if((sender as Button).BackgroundColor == Color.CadetBlue)
            {
                (sender as Button).BackgroundColor = Color.Yellow;
                chosenSeats.Remove((((Button)sender).BindingContext) as Model.Seat);
            }
        }

        private async void BtnPay_Clicked(object sender, EventArgs e)
        {
            if (chosenSeats.Count == 0)
            {
                await DisplayAlert("Thông báo", "Bạn chưa chọn chỗ ngồi", "OK");
            }
            else
            {
                await Navigation.PushAsync(new ConfirmPayPage(this.chosenMovie, this.chosenCinema,
                                                              this.time, chosenSeats));
            }
        }
    }
}