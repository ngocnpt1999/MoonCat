using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace MoonCat.Model
{
    public class ListMovieShowing
    {
        public ObservableCollection<Movie> MoviesShowing { get; set; }

        public ListMovieShowing()
        {
            var dbConnection = DependencyService.Get<ISQLiteDatabase>().CreateConnection();
            var movies = dbConnection.Query<Movie>("SELECT * FROM Movie");
            var showing = dbConnection.Query<MovieShowing>("SELECT * FROM MovieShowing");
            var list = (from m in movies join s in showing on m.ID equals s.ID_Movie select m).Distinct();
            MoviesShowing = new ObservableCollection<Movie>(list);
        }
    }
}
