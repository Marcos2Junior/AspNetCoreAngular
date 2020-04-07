using System;
using JujubaControle_API.Models.Enum.DbEnum;

namespace JujubaControle_API.Models.DbModels
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Nick { get; set; }
        public string Pass { get; set; }
        public DateTime Birth_date { get; set; }
        public Role Role { get; set; }
        public DateTime Date { get; set; }

        public User()
        {
        }

        public User(int id, string login, string name, string nick, string pass, DateTime birth_date, Role role, DateTime date)
        {
            Id = id;
            Login = login;
            Name = name;
            Nick = nick;
            Pass = pass;
            Birth_date = birth_date;
            Role = role;
            Date = date;
        }
    }
}