using System;
namespace tccxamarin.Models
{
    public class Starred
    {
        public string name { get; set; }
        public string full_name { get; set; }
        public Owner owner { get; set; }
        public string avatar_url { get; set;}
        public string login { get; set; }

        public Starred(string name, string full_name, Owner owner)
        {
            this.name = name;
            this.full_name = full_name;
            this.owner = owner;
            avatar_url = owner.avatar_url;
            login = owner.login;
        }
    }

    public class Owner
    {
        public string login { get; set; }
        public string avatar_url { get; set; }

        public Owner(string login, string avatar_url)
        {
            this.login = login;
            this.avatar_url = avatar_url;
        }
    }
}
