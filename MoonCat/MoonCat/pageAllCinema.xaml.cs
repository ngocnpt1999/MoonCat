using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoonCat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllCinemaPage : ContentPage
    {
        private Model.ListAllCinema listAllCinema = new Model.ListAllCinema();

        public AllCinemaPage()
        {
            InitializeComponent();
            lvCinema.ItemsSource = listAllCinema.Cinemas;
        }

        private async void LvCinema_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var cinema = ((ListView)sender).SelectedItem as Model.Cinema;
            var dbConnection = DependencyService.Get<ISQLiteDatabase>().CreateConnection();
            var listImage = dbConnection.Query<Model.ImageCinema>("SELECT * FROM ImageCinema WHERE id_cinema = ?", new object[1] { cinema.ID });
            Model.CinemaInfo cinemaInfo = new Model.CinemaInfo()
            {
                ID = cinema.ID,
                Name = cinema.Name,
                Address = cinema.Address,
                Phone = cinema.Phone,
                X = cinema.X,
                Y = cinema.Y,
                Images = new ObservableCollection<Model.ImageCinema>(listImage)
            };
            await Navigation.PushAsync(new CinemaInfoPage(cinemaInfo));
            ((ListView)sender).SelectedItem = null;
        }
    }
}