// https://www.microsoft.com/net/tutorials/csharp/getting-started/classes-objects

using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Address
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public string FormatAddress()
        {
            return $"{StreetAddress}\n {City}, {State}, {PostalCode}\n {Country}";
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address ShippingAddress { get; set; }

        public void DisplayPerson()
        {
            Console.WriteLine($"{FirstName} {LastName}\n {ShippingAddress.FormatAddress()}\n");
        }
    }

    public class Company
    {
        public string Name { get; set; }
        public Address ShippingAddress { get; set; }

        public void DisplayCompany()
        {
            Console.WriteLine($"{Name}\n {ShippingAddress.FormatAddress()}\n");
        }
    }

    public class Program
    {
        public static void Main()
        {
            var ShippingAddress1 = new Address()
            {
                StreetAddress = "123 Main Street",
                City = "Sometown",
                State = "OH",
                PostalCode = "12345",
                Country = "United States"
            };
            var Person1 = new Person()
            {
                FirstName = "John",
                LastName = "Doe",
                ShippingAddress = ShippingAddress1
            };
            var Person2 = new Person()
            {
                FirstName = "Jane",
                LastName = "Doe",
                ShippingAddress = ShippingAddress1
            };
            var Company1 = new Company()
            {
                Name = "Acme, Inc.",
                ShippingAddress = ShippingAddress1
            };
            Person1.DisplayPerson();
            Person2.DisplayPerson();
            Company1.DisplayCompany();
        }
    }
}