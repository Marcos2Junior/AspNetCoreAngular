using System;
using JujubaControle_API.Models.Enum.DbEnum;

namespace JujubaControle_API.Models.DbModels
{
    public class Address
    {
         public int Id { get; set; }
        public TypeAddress Type_Address { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip_Code { get; set; }
        public string Complement { get; set; }
        public string Reference { get; set; }
        public DateTime Date { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

        public Address() { }

        public Address(int id, TypeAddress type_Address, string name, string street,
            string number, string neighborhood, string state, string country, string zip_Code,
            string complement, string reference, DateTime date, User user)
        {
            Id = id;
            Type_Address = type_Address;
            Name = name;
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            State = state;
            Country = country;
            Zip_Code = zip_Code;
            Complement = complement;
            Reference = reference;
            Date = date;
            User = user;
        }
    }
}