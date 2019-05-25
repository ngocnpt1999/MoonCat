﻿using System;
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
            new MenuItem(){Title="Visa/MasterCard", Image="card.png", TargetType=typeof(CreditCardPage)},
            new MenuItem(){Title="Thẻ ngân hàng", Image="bank.png", TargetType=typeof(E_BankingPage)},
            new MenuItem(){Title="Ví MoMo", Image="wallet.png"}
        };

        public MethodPaymentPage()
        {
            InitializeComponent();
            lvMethod.ItemsSource = methods;
        }

        private async void LvMethod_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = ((ListView)sender).SelectedItem as MenuItem;
            if (vm.TargetType != null)
            {
                var page = (Page)Activator.CreateInstance(vm.TargetType);
                await Navigation.PushAsync(page);
            }
            ((ListView)sender).SelectedItem = null;
        }
    }
}