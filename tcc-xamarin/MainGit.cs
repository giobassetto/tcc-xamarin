using System;

using Xamarin.Forms;

namespace tccxamarin
{
    public class MainGit : ContentPage
    {
        public MainGit()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

