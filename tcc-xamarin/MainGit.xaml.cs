using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        string loginUser = "";
        ObservableCollection<User> Users = new ObservableCollection<User>();

        public MainGit()
        {
            InitializeComponent();
            list1.ItemsSource = Users;
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            var client = new HttpClient();
            var uri = "https://api.github.com/users/" + loginUser;
            var result = await client.GetStringAsync(uri);
            var user = JsonConvert.DeserializeObject<User>(result);


            Users.Add(user);
        }

        void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            loginUser = e.NewTextValue;
        }

        void ProfileClicked(object sender, EventArgs args, User user)
        {
            Console.WriteLine(user);
        }
    }
}