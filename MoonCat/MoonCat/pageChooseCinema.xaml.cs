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
        private Model.Movie chosenMovie;
        private Model.ListChooseCinema listChooseCinema;

        public ChooseCinemaPage(Model.Movie movie)
        {
            InitializeComponent();
            this.chosenMovie = movie;
            listChooseCinema = new Model.ListChooseCinema(this.chosenMovie.ID);
            lvChooseCinema.ItemsSource = listChooseCinema.Cinemas;
        }

        private async void LvChooseCinema_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = ((ListView)sender).SelectedItem as Model.Cinema;
            await Navigation.PushAsync(new BeginTimePage(this.chosenMovie, vm));
            ((ListView)sender).SelectedItem = null;
        }
    }
}