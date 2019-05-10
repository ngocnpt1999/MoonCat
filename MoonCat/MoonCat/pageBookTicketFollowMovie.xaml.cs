﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoonCat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookTicketFollowMoviePage : ContentPage
    {
        private Model.ListMovieShowing listMovie = new Model.ListMovieShowing();

        public BookTicketFollowMoviePage()
        {
            InitializeComponent();
            lvMovieShowing.ItemsSource = this.listMovie.MoviesShowing;
        }

        private async void LvMovieShowing_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = ((ListView)sender).SelectedItem as Model.Movie;
            Model.BookingInfo booking = new Model.BookingInfo() { MovieInfo = vm };
            await Navigation.PushAsync(new MovieDetailPage(booking, true));
            ((ListView)sender).SelectedItem = null;
        }
    }
}