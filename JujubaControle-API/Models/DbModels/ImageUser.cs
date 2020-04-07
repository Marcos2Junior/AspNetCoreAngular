using System;

namespace JujubaControle_API.Models.DbModels
{
    public class ImageUser
    {
       
        public int Id { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public string Path { get; set; }
        public DateTime date { get; set; }

        public ImageUser()
        { }

        public ImageUser(int id, User user,  string path, DateTime date)
        {
            this.Id = id;
            this.User = user;
            this.Path = path;
            this.date = date;
        }
    }
}