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

            await Navigation.PushAsync(new MovieDetailPage(((ListView)sender).SelectedItem as Model.Movie, true));

            ((ListView)sender).SelectedItem = null;
        }
    }
}