using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CustomerManager customerManager = new CustomerManager(); //örneğin camel case
            customerManager.Add();
            customerManager.Update();

            ProduktManager produktManager = new ProduktManager();
            produktManager.Add();
            produktManager.Update();

            Customer customer = new Customer();
            customer.FirstName = "Büşra";
            customer.LastName = "Çalışkan";
            customer.Id = 1;
            customer.City = "İstanbul";

            Customer customer2 = new Customer
            {
                City = "İstanbul", Id = 2, FirstName = "Derin", LastName = "Demir"
            };

            Console.WriteLine(customer.FirstName);
            Console.ReadLine();
        }
    }
    
    

}
