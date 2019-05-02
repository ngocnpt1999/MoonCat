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
    public partial class TrailerWebViewPage : ContentPage
    {
        public TrailerWebViewPage(string url)
        {
            InitializeComponent();
            var wvTrailer = new WebView();
            wvTrailer.Source = url;
            Content = wvTrailer;
        }
    }
}