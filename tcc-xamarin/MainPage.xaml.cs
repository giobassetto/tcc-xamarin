using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tccxamarin;
using Xamarin.Forms;

namespace AppTcc2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        async private void _navigationMainGit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainGit());
        }

        async private void _navigationCamera(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Camera() { Title = "Câmera" });
        }
        async private void _navigationBenchmark(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Benchmark() { Title = "Benchmark" });
        }
    }
}