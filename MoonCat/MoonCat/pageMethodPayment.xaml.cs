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
    public partial class MethodPaymentPage : ContentPage
    {
        private ObservableCollection<MenuItem> methods = new ObservableCollection<MenuItem>()
        {
            new MenuItem(){Title="Visa/MasterCard"},
            new MenuItem(){Title="Thẻ ngân hàng"},
            new MenuItem(){Title="Ví MoMo"}
        };

        public MethodPaymentPage()
        {
            InitializeComponent();
            lvMethod.ItemsSource = methods;
        }

        private void LvMethod_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}