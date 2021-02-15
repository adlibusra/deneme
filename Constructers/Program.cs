﻿using System;

namespace Constructers // yapıcı blok newlemek 
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer { Id = 1, FirstName = "Engin,", LastName = "Demiroğ", City = "Ankara" };
            Customer customer2 = new Customer(2,"Derin", "Demiroğ","Ankara");

            Console.WriteLine(customer2.FirstName);
        }
        
    }
    class Customer
    {
        public Customer()
        {

        }

        // default constructor= paremetresi olmayan constructor
        public Customer(int id,string firstname, string lastName, string city) // ctor yazdık tab tab
        {
            Id = id;
            FirstName = firstname;
            LastName = lastName;
            City = city;
            Console.ReadLine();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

       
    }
    
}
