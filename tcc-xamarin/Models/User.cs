using System;
namespace tccxamarin.Models
{
    public class User
    {
        public String login { get; set; }
        public String name { get; set; }
        public String bio { get; set; }
        public String avatar_url { get; set; }

        public User(String login, String name, String bio, String avatar_url)
        {
            this.login = login;
            this.name = name;
            this.bio = bio;
            this.avatar_url = avatar_url;
        }
    }
}
