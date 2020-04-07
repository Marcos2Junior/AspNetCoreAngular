using System;

namespace JujubaControle_API.Models.DbModels
{
    public class ExceptionDb
    {
        public int Id { get; set; }
        public string Class { get; set; }
        public string Method { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

        public ExceptionDb()
        { }

        public ExceptionDb(int id, string @class, string method, bool status, string message, DateTime date, User user)
        {
            Id = id;
            Class = @class;
            Method = method;
            Status = status;
            Message = message;
            Date = date;
            User = user;
        }
    }
}