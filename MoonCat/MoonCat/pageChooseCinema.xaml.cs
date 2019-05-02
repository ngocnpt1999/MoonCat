using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoonCat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChooseCinemaPage : ContentPage
    {
        private int id_movie;
        private Model.ListChooseCinema listChooseCinema;

        public ChooseCinemaPage(int id_movie)
        {
            InitializeComponent();
            this.id_movie = id_movie;
            listChooseCinema = new Model.ListChooseCinema(this.id_movie);
            lvChooseCinema.ItemsSource = listChooseCinema.Cinemas;
        }

        private async void LvChooseCinema_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = ((ListView)sender).SelectedItem as Model.Cinema;
            await Navigation.PushAsync(new BeginTimePage(this.id_movie, vm.ID));
            ((ListView)sender).SelectedItem = null;
        }
    }
}