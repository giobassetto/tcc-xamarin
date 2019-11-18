using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Newtonsoft.Json;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using tccxamarin.Models;
using tccxamarin;

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
            GetUsers();
            list1.ItemsSource = Users;
            
        }

        private async void GetUsers()
        {
            var users = await SecureStorage.GetAsync("Users");
            if (users == null) return;
            var jsonDecoded = JsonConvert.DeserializeObject<List<User>>(users);
            foreach(User user in jsonDecoded)
            {
                Users.Add(user);
            }
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            var client = new HttpClient();
            var uri = "https://api.github.com/users/" + loginUser;
            var result = await client.GetStringAsync(uri);
            var user = JsonConvert.DeserializeObject<User>(result);

            
            Users.Add(user);

            var users = JsonConvert.SerializeObject(Users.ToList());
            Console.WriteLine("Usuários: " + users);
            await SecureStorage.SetAsync("Users", users);
        }

        void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            loginUser = e.NewTextValue;
        }

        async void ProfileUser(object sender, System.EventArgs e)
        {
            var button = sender as Button;
            var user = button.CommandParameter as User;
            await Navigation.PushAsync(new UserPage(user) { Title = user.name });
        }

        void RemoveUser(System.Object sender, System.EventArgs e)
        {
            var button = sender as Button;
            var user = button.CommandParameter as User;
            Users.Remove(user);
            var users = JsonConvert.SerializeObject(Users.ToList());
            SecureStorage.SetAsync("Users", users);
        }
    }
}
