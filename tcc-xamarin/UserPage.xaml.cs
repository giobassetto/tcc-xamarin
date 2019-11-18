using System;
using System.Collections.Generic;
using tccxamarin.Models;
using Xamarin.Forms;

namespace tccxamarin
{
    public partial class UserPage : ContentPage
    {
        public UserPage()
        {
        }

        public UserPage(User user)
        {
            InitializeComponent();
            lbName.Text = user.name;
            lbBio.Text = user.bio;
        }
    }
}
