using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoonCat.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterMainPage : MasterDetailPage
    {
        private ObservableCollection<MenuItem> items = new ObservableCollection<MenuItem>()
        {
            new MenuItem(){Title="Đặt vé theo phim",TargetType=typeof(BookTicketFollowMoviePage)},
            new MenuItem(){Title="Đặt vé theo rạp",TargetType=typeof(BookTicketFollowCinemaPage)}
        };

        public MasterMainPage()
        {
            InitializeComponent();
            lvItems.HeightRequest = (50 * items.Count) + (10 * items.Count);
            lvItems.ItemsSource = items;
        }

        private void IbtnUser_Tapped(object sender, EventArgs e)
        {

        }

        private void IbtnHome_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new HomeTabbedPage());
            IsPresented = false;
        }

        private void IbtnMember_Tapped(object sender, EventArgs e)
        {

        }

        private void IbtnGift_Tapped(object sender, EventArgs e)
        {

        }

        private void IbtnCinemaReview_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AllCinemaPage());
            IsPresented = false;
        }

        private void LvItems_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = ((ListView)sender).SelectedItem as MenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            ((ListView)sender).SelectedItem = null;
        }
    }
}