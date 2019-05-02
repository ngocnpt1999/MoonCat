using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections.ObjectModel;
using SQLite;
using Xamarin.Forms;

namespace MoonCat.Model
{
    public class ListMovieComingSoon
    {
        public ObservableCollection<Movie> MoviesComingSoon { get; set; }

        public ListMovieComingSoon()
        {
            var dbConnection = DependencyService.Get<ISQLiteDatabase>().CreateConnection();
            var movies = dbConnection.Query<Movie>("SELECT * FROM Movie");
            DateTime begin = new DateTime(2019, 4, 27);
            DateTime end = new DateTime(2019, 5, 31);
            var list = (from m in movies
                        where Convert.ToDateTime(m.Premiere) >= begin
                        && Convert.ToDateTime(m.Premiere) <= end
                        select m);
            MoviesComingSoon = new ObservableCollection<Movie>(list);
        }
    }
}
