using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoonCat.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class E_BankingPage : ContentPage
    {
        private Model.ListBank listBank = new Model.ListBank();

        public E_BankingPage()
        {
            InitializeComponent();
            cvBank.ItemsSource = listBank.Banks;
        }

        private async void CvBank_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (((CollectionView)sender).SelectedItem == null)
            {
                return;
            }
            await DisplayAlert("Thông báo", "Maemoe", "OK");
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}