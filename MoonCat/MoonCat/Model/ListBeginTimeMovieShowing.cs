using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Linq;
using MoonCat.Interface;

namespace MoonCat.Model
{
    public class ListBeginTimeMovieShowing
    {
        public ObservableCollection<Timer> BeginTime { get; set; }

        public ListBeginTimeMovieShowing(int id_movie, int id_cinema)
        {
            var dbConnection = DependencyService.Get<ISQLiteDatabase>().CreateConnection();
            var showing = dbConnection.Query<MovieShowing>("SELECT * FROM MovieShowing" +
                                                           " WHERE id_movie = ? AND id_cinema = ?",
                                                           new object[2] { id_movie, id_cinema });
            var list = (from ms in showing select new Timer { Time = ms.Begin });
            BeginTime = new ObservableCollection<Timer>(list);
        }
    }
}
