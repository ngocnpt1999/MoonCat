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
    public partial class MasterMainPage : MasterDetailPage
    {
        private ObservableCollection<MasterMainMenuItem> items = new ObservableCollection<MasterMainMenuItem>()
        {
            new MasterMainMenuItem(){Title="Đặt vé theo phim",TargetType=typeof(MovieShowingPage)},
            new MasterMainMenuItem(){Title="Đặt vé theo rạp",TargetType=typeof(BookTicketFollowCinemaPage)}
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

        private void lvItems_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterMainMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            lvItems.SelectedItem = null;
        }
    }
}