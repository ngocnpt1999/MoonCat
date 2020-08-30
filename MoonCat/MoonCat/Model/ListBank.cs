using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using SQLite;
using Xamarin.Forms;
using MoonCat.Interface;

namespace MoonCat.Model
{
    public class ListBank
    {
        public ObservableCollection<Bank> Banks { get; set; }

        public ListBank()
        {
            var dbConnection = DependencyService.Get<ISQLiteDatabase>().CreateConnection();
            var list = dbConnection.Query<Bank>("SELECT * FROM Bank");
            Banks = new ObservableCollection<Bank>(list);
        }
    }
}
