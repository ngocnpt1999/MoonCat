using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using MoonCat.Interface;

namespace MoonCat.Model
{
    public class ListChooseCinema
    {
        public ObservableCollection<Cinema> Cinemas { get; set; }

        public ListChooseCinema(int id_movie)
        {
            var dbConnection = DependencyService.Get<ISQLiteDatabase>().CreateConnection();
            var showing = dbConnection.Query<MovieShowing>("SELECT * FROM MovieShowing" +
                                                           " WHERE id_movie = ?", new object[1] { id_movie });
            var cinema = dbConnection.Query<Cinema>("SELECT * FROM Cinema");
            var list = (from c in cinema
                        join ms in showing
                        on c.ID equals ms.ID_Cinema
                        select c).Distinct();
            Cinemas = new ObservableCollection<Cinema>(list);
        }
    }
}
