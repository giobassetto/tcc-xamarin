using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using tccxamarin.Models;

namespace AppTcc2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainGit : ContentPage
    {
        Label testResponse = new Label();
        List<User> users = new List<User>();
        string loginUser = "";
        

        public MainGit()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            var client = new HttpClient();
            var uri = "https://api.github.com/users/" + loginUser;
            var result = await client.GetStringAsync(uri);
            var user = JsonConvert.DeserializeObject<User>(result);

            users.Add(user);
        }

        void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            loginUser = e.NewTextValue;
        }
    }
}