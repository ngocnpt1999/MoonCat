using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using SQLite;
using Xamarin.Forms;

namespace MoonCat.Model
{
    public class ListAllCinema
    {
        public ObservableCollection<Cinema> Cinemas { get; set; }

        public ListAllCinema()
        {
            var dbConnection = DependencyService.Get<ISQLiteDatabase>().CreateConnection();
            var list = dbConnection.Query<Cinema>("SELECT * FROM Cinema");
            Cinemas = new ObservableCollection<Cinema>(list);
        }
    }
}
