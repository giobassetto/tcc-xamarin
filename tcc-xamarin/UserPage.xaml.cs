using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;
using tccxamarin.Models;
using Xamarin.Forms;

namespace tccxamarin
{
    public partial class UserPage : ContentPage
    {
        ObservableCollection<Starred> Starreds = new ObservableCollection<Starred>();
        public UserPage(User user)
        {
            InitializeComponent();
            getStarreds(user.login);
            imageAvatar.Source = user.avatar_url;
            lbName.Text = user.name;
            lbBio.Text = user.bio;
            listStarreds.ItemsSource = Starreds;
        }

        public async void getStarreds(string login)
        {
            var client = new HttpClient();
            var uri = "https://api.github.com/users/" + login + "/starred";
            var result = await client.GetStringAsync(uri);
            var starreds = JsonConvert.DeserializeObject<List<Starred>>(result);
            foreach(Starred star in starreds)
            {
                Starreds.Add(star);
            }
        }
    }
}
