using System;
using AppTcc2;
using Plugin.Media;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tcc_xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage()) { BarBackgroundColor = Color.FromHex("3700B3"), BarTextColor = Color.White };
        }

        protected override async void OnStart()
        {
            await CrossMedia.Current.Initialize();
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
