using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoonCat
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Get<ISQLiteDatabase>().CopyDatabaseIfNotExists();

            MainPage = new MasterMainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
