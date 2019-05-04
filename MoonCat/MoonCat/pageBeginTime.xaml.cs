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
    public partial class BeginTimePage : ContentPage
    {
        private int id_movie;
        private int id_cinema;
        private Model.ListBeginTimeMovieShowing listTime;

        public BeginTimePage(int id_movie, int id_cinema)
        {
            InitializeComponent();
            this.id_movie = id_movie;
            this.id_cinema = id_cinema;
            listTime = new Model.ListBeginTimeMovieShowing(this.id_movie, this.id_cinema);
            lvTime.ItemsSource = listTime.BeginTime;
        }

        private async void LvTime_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = ((ListView)sender).SelectedItem as Model.Timer;
            var dbConnection = DependencyService.Get<ISQLiteDatabase>().CreateConnection();
            var showing = dbConnection.Query<Model.MovieShowing>("SELECT * FROM MovieShowing" +
                " WHERE id_movie = ? AND id_cinema = ? AND date = ? AND begin = ?",
                new object[4]
                {
                    this.id_movie,
                    this.id_cinema,
                    "27/04/2019",
                    vm.Time
                });
            await Navigation.PushAsync(new SeatMovieShowingPage(showing[0].ID));
            ((ListView)sender).SelectedItem = null;
        }
    }
}