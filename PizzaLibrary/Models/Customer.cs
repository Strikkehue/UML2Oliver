using PizzaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLibrary.Models
{
    public class Customer : ICustomer
    {
        private static int counter=0;
        public Customer(string name, string mobile, string address, string city, bool isClubmember)
        {
            Id = counter++;
            Name = name;
            Mobile = mobile;
            Address = address;
            ClubMember = isClubmember;
            City = city;
        }

        public string Address { get ; set ; }
        public bool ClubMember { get ; set ; }

        public int Id { get; private set; }

        public string Mobile { get ; set ; }
        public string Name { get ; set ; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"Customer {Id}: Name: {Name} Mobile: {Mobile} Address: {Address} City: {City}";
        }
    }
}
