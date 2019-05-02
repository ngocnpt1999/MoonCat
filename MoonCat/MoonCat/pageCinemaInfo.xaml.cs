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
    public partial class CinemaInfoPage : ContentPage
    {
        private Model.CinemaInfo cinemaInfo;

        public CinemaInfoPage(Model.CinemaInfo cinemaInfo)
        {
            InitializeComponent();
            this.cinemaInfo = cinemaInfo;
            BindingContext = this.cinemaInfo;
        }

        private async void MapMarker_Tapped(object sender, EventArgs e)
        {
            var marker = new Xamarin.Essentials.Location(this.cinemaInfo.X, this.cinemaInfo.Y);
            var options = new Xamarin.Essentials.MapLaunchOptions()
            {
                Name = this.cinemaInfo.Name,
                NavigationMode = Xamarin.Essentials.NavigationMode.None
            };
            await Xamarin.Essentials.Map.OpenAsync(marker, options);
        }
    }
}